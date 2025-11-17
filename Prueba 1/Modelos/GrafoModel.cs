using System;
using System.Collections.Generic;
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

        // Conexión bidireccional
        public bool Conectar(string origen, string destino, int distancia)
        {
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino)) return false;
            if (string.Equals(origen, destino, StringComparison.OrdinalIgnoreCase)) return false;
            if (distancia <= 0) return false;
            if (!_adj.ContainsKey(origen) || !_adj.ContainsKey(destino)) return false;

            // Evitar duplicados exactos
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
    }
}
