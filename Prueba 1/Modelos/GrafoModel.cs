using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba_1.Modelos
{
    internal class GrafoModel
    {
        // Lista de adyacencia: vértice -> (vecino, peso)
        private readonly Dictionary<string, List<(string vecino, double peso)>> _adj 
            = new Dictionary<string, List<(string vecino, double peso)>>(StringComparer.OrdinalIgnoreCase);

        public IReadOnlyCollection<string> Vertices => _adj.Keys;

        public void AgregarVertice(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del edificio no puede estar vacío.", nameof(nombre));

            if (!_adj.ContainsKey(nombre))
                _adj[nombre] = new List<(string vecino, double peso)>();
        }

        // Grafo no dirigido: agrega en ambos sentidos. Si existe, actualiza el peso.
        public void AgregarArista(string desde, string hasta, double peso)
        {
            if (string.IsNullOrWhiteSpace(desde) || string.IsNullOrWhiteSpace(hasta))
                throw new ArgumentException("Los nombres de los edificios no pueden estar vacíos.");
            if (string.Equals(desde, hasta, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("No se permiten bucles (mismo edificio).");
            if (peso < 0)
                throw new ArgumentOutOfRangeException(nameof(peso), "El peso no puede ser negativo.");

            AgregarVertice(desde);
            AgregarVertice(hasta);

            AgregarOActualizar(desde, hasta, peso);
            AgregarOActualizar(hasta, desde, peso);
        }

        private void AgregarOActualizar(string origen, string destino, double peso)
        {
            var vecinos = _adj[origen];
            var idx = vecinos.FindIndex(x => string.Equals(x.vecino, destino, StringComparison.OrdinalIgnoreCase));
            if (idx >= 0) vecinos[idx] = (destino, peso);
            else vecinos.Add((destino, peso));
        }

        public IEnumerable<(string Desde, string Hasta, double Peso)> ObtenerAristas()
        {
            var visto = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var u in _adj.Keys)
            {
                foreach (var (v, w) in _adj[u])
                {
                    // Emitir solo una vez por arista no dirigida
                    var clave = u.CompareTo(v) < 0 ? $"{u}|{v}" : $"{v}|{u}";
                    if (visto.Add(clave))
                        yield return (u.CompareTo(v) < 0 ? u : v, u.CompareTo(v) < 0 ? v : u, w);
                }
            }
        }

        public IEnumerable<(string Vecino, double Peso)> ObtenerAdyacentes(string vertice)
        {
            if (!_adj.ContainsKey(vertice)) yield break;
            foreach (var par in _adj[vertice]) yield return par;
        }

        public bool SonAdyacentes(string a, string b)
        {
            if (!_adj.ContainsKey(a) || !_adj.ContainsKey(b)) return false;
            return _adj[a].Any(x => string.Equals(x.vecino, b, StringComparison.OrdinalIgnoreCase));
        }

        // Conexidad: todos los vértices alcanzables entre sí (un único componente)
        public bool EsConexo()
        {
            if (_adj.Count <= 1) return true;

            var inicio = _adj.Keys.First();
            var visitados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var q = new Queue<string>();
            q.Enqueue(inicio);
            visitados.Add(inicio);

            while (q.Count > 0)
            {
                var u = q.Dequeue();
                foreach (var (v, _) in _adj[u])
                {
                    if (visitados.Add(v))
                        q.Enqueue(v);
                }
            }

            return visitados.Count == _adj.Count;
        }

        // BFS: ruta mínima en número de aristas (ignora pesos)
        public List<string> RutaBfs(string origen, string destino)
        {
            if (!_adj.ContainsKey(origen) || !_adj.ContainsKey(destino)) return new List<string>();

            var q = new Queue<string>();
            var prev = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var visit = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            q.Enqueue(origen);
            visit.Add(origen);

            while (q.Count > 0)
            {
                var u = q.Dequeue();
                if (string.Equals(u, destino, StringComparison.OrdinalIgnoreCase))
                    return ReconstruirCamino(prev, origen, destino);

                foreach (var (v, _) in _adj[u])
                {
                    if (visit.Add(v))
                    {
                        prev[v] = u;
                        q.Enqueue(v);
                    }
                }
            }

            return new List<string>();
        }

        // Dijkstra: ruta de costo mínimo (usa búsqueda lineal del mínimo; suficiente para grafos pequeños)
        public (double Distancia, List<string> Camino) RutaDijkstra(string origen, string destino)
        {
            if (!_adj.ContainsKey(origen) || !_adj.ContainsKey(destino))
                return (double.PositiveInfinity, new List<string>());

            var dist = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
            var prev = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var noVisitados = new HashSet<string>(_adj.Keys, StringComparer.OrdinalIgnoreCase);

            foreach (var v in _adj.Keys) dist[v] = double.PositiveInfinity;
            dist[origen] = 0.0;

            while (noVisitados.Count > 0)
            {
                // seleccionar no visitado con menor distancia
                string u = null;
                var min = double.PositiveInfinity;
                foreach (var v in noVisitados)
                {
                    var dv = dist[v];
                    if (dv < min)
                    {
                        min = dv;
                        u = v;
                    }
                }

                if (u == null || double.IsPositiveInfinity(dist[u]))
                    break; // resto inalcanzable

                noVisitados.Remove(u);

                if (string.Equals(u, destino, StringComparison.OrdinalIgnoreCase))
                    break;

                foreach (var (v, w) in _adj[u])
                {
                    if (!noVisitados.Contains(v)) continue;
                    var alt = dist[u] + w;
                    if (alt < dist[v])
                    {
                        dist[v] = alt;
                        prev[v] = u;
                    }
                }
            }

            if (double.IsPositiveInfinity(dist[destino]))
                return (double.PositiveInfinity, new List<string>());

            var camino = ReconstruirCamino(prev, origen, destino);
            return (dist[destino], camino);
        }

        private static List<string> ReconstruirCamino(Dictionary<string, string> prev, string origen, string destino)
        {
            var camino = new List<string>();
            var cur = destino;
            while (!string.IsNullOrEmpty(cur))
            {
                camino.Add(cur);
                if (string.Equals(cur, origen, StringComparison.OrdinalIgnoreCase)) break;
                if (!prev.TryGetValue(cur, out cur)) return new List<string>(); // sin camino
            }
            camino.Reverse();
            return camino;
        }
    }
}
