using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_1.Modelos
{
    internal class GrafoModel
    {
        private class Arista
        {
            public string Destino { get; }
            public int Distancia { get; }

            public Arista(string destino, int distancia)
            {
                Destino = destino;
                Distancia = distancia;
            }
        }

        // Lista de adyacencia: edificio -> lista de aristas
        private readonly Dictionary<string, List<Arista>> _adj = new Dictionary<string, List<Arista>>(StringComparer.OrdinalIgnoreCase);

        public bool AgregarEdificio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            if (_adj.ContainsKey(nombre)) return false;
            _adj[nombre] = new List<Arista>();
            return true;
        }

        
        public bool Conectar(string origen, string destino, int distancia)
        {
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino)) return false;
            if (string.Equals(origen, destino, StringComparison.OrdinalIgnoreCase)) return false;
            if (distancia <= 0) return false;
            if (!_adj.ContainsKey(origen) || !_adj.ContainsKey(destino)) return false;

            if (!_adj[origen].Exists(a => a.Destino.Equals(destino, StringComparison.OrdinalIgnoreCase)))
            {
                _adj[origen].Add(new Arista(destino, distancia));
            }
            if (!_adj[destino].Exists(a => a.Destino.Equals(origen, StringComparison.OrdinalIgnoreCase)))
            {
                _adj[destino].Add(new Arista(origen, distancia));
            }
            return true;
        }

        public string RepresentacionTexto()
        {
            if (_adj.Count == 0) return "Grafo vacío.";
            var sb = new StringBuilder();
            foreach (var kv in _adj)
            {
                sb.Append(kv.Key).Append(" -> ");
                if (kv.Value.Count == 0)
                {
                    sb.Append("(sin conexiones)");
                }
                else
                {
                    for (int i = 0; i < kv.Value.Count; i++)
                    {
                        var a = kv.Value[i];
                        sb.Append(a.Destino).Append(" (").Append(a.Distancia).Append(")");
                        if (i < kv.Value.Count - 1) sb.Append(", ");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        // BFS: retorna cadena con la ruta y distancia total, o mensaje de no encontrada
        public string RutaBfs(string origen, string destino)
        {
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
                return "Origen o destino vacíos.";
            if (!_adj.ContainsKey(origen) || !_adj.ContainsKey(destino))
                return "Uno o ambos edificios no existen en el grafo.";
            if (string.Equals(origen, destino, StringComparison.OrdinalIgnoreCase))
                return "Origen y destino son el mismo.";

            var visitados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var prev = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var q = new Queue<string>();
            visitados.Add(origen);
            q.Enqueue(origen);

            bool encontrado = false;
            while (q.Count > 0 && !encontrado)
            {
                var actual = q.Dequeue();
                foreach (var arista in _adj[actual])
                {
                    var vecino = arista.Destino;
                    if (!visitados.Contains(vecino))
                    {
                        visitados.Add(vecino);
                        prev[vecino] = actual;
                        if (vecino.Equals(destino, StringComparison.OrdinalIgnoreCase))
                        {
                            encontrado = true;
                            break;
                        }
                        q.Enqueue(vecino);
                    }
                }
            }

            if (!encontrado) return $"No existe ruta entre '{origen}' y '{destino}'.";

            // Reconstruir ruta
            var ruta = new List<string>();
            string nodo = destino;
            while (!nodo.Equals(origen, StringComparison.OrdinalIgnoreCase))
            {
                ruta.Add(nodo);
                nodo = prev[nodo];
            }
            ruta.Add(origen);
            ruta.Reverse();

            int distanciaTotal = 0;
            for (int i = 0; i < ruta.Count - 1; i++)
            {
                var desde = ruta[i];
                var hacia = ruta[i + 1];
                var arista = _adj[desde].First(a => a.Destino.Equals(hacia, StringComparison.OrdinalIgnoreCase));
                distanciaTotal += arista.Distancia;
            }

            return $"Ruta ({ruta.Count} edificios, distancia total {distanciaTotal}): " + string.Join(" -> ", ruta);
        }
    }
}
