using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Grafo
{

    public partial class Form1 : Form
    {
        // ==== ÁRBOL ====
        NodoArbol raiz; // raíz del árbol

        // ==== GRAFO ====
        List<Vertice> vertices = new List<Vertice>();

        public Form1()
        {
            InitializeComponent();

            // Eventos árbol
            btnInsertarNodo.Click += btnInsertarNodo_Click;
            btnEliminarNodo.Click += btnEliminarNodo_Click;
            btnBuscarNodo.Click += btnBuscarNodo_Click;
            btnPreorden.Click += btnPreorden_Click;
            btnPostorden.Click += btnPostorden_Click;
            btnPorNiveles.Click += btnPorNiveles_Click;

            // Eventos grafo
            btnAgregarEdificio.Click += btnAgregarEdificio_Click;
            btnAgregarConexion.Click += btnAgregarConexion_Click;
            btnMostrarAdyacencias.Click += btnMostrarAdyacencias_Click;
            btnEsConexo.Click += btnEsConexo_Click;
            btnCalcularRuta.Click += btnCalcularRuta_Click;
        }

        // ================== LÓGICA BÁSICA DEL ÁRBOL ==================

        NodoArbol BuscarNodo(NodoArbol actual, string nombre)
        {
            if (actual == null) return null;
            if (string.Equals(actual.Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                return actual;

            foreach (var h in actual.Hijos)
            {
                var r = BuscarNodo(h, nombre);
                if (r != null) return r;
            }
            return null;
        }

        bool EliminarNodo(NodoArbol actual, string nombre)
        {
            // intenta eliminar en la lista de hijos
            for (int i = 0; i < actual.Hijos.Count; i++)
            {
                if (string.Equals(actual.Hijos[i].Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                {
                    actual.Hijos.RemoveAt(i);
                    return true;
                }
                if (EliminarNodo(actual.Hijos[i], nombre))
                    return true;
            }
            return false;
        }

        void RefrescarTreeView()
        {
            tvArbolOrganizacional.Nodes.Clear();
            if (raiz != null)
                CrearNodoTree(raiz, tvArbolOrganizacional.Nodes);
            tvArbolOrganizacional.ExpandAll();
        }

        void CrearNodoTree(NodoArbol nodo, TreeNodeCollection col)
        {
            TreeNode tn = new TreeNode(nodo.Nombre);
            col.Add(tn);
            foreach (var h in nodo.Hijos)
                CrearNodoTree(h, tn.Nodes);
        }

        // ================== BOTONES ÁRBOL ==================

        void btnInsertarNodo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNodo.Text.Trim();
            string padre = txtPadreNodo.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                txtResultadosArbol.Text = "Ingrese un nombre de nodo.";
                return;
            }

            // Si no hay raíz, este será la raíz
            if (raiz == null)
            {
                raiz = new NodoArbol(nombre);
                RefrescarTreeView();
                return;
            }

            // Insertar debajo de un padre
            if (string.IsNullOrEmpty(padre))
            {
                txtResultadosArbol.Text = "Para insertar hijos, escriba el nombre del padre.";
                return;
            }

            var nodoPadre = BuscarNodo(raiz, padre);
            if (nodoPadre == null)
            {
                txtResultadosArbol.Text = $"No se encontró el padre \"{padre}\".";
                return;
            }

            // Evitar duplicado simple
            if (BuscarNodo(raiz, nombre) != null)
            {
                txtResultadosArbol.Text = $"Ya existe un nodo llamado \"{nombre}\".";
                return;
            }

            nodoPadre.Hijos.Add(new NodoArbol(nombre));
            RefrescarTreeView();
            txtNombreNodo.Clear();
            txtPadreNodo.Clear();
        }

        void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreNodo.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                txtResultadosArbol.Text = "Escriba el nombre del nodo a eliminar en txtNombreNodo.";
                return;
            }

            if (raiz == null)
            {
                txtResultadosArbol.Text = "El árbol está vacío.";
                return;
            }

            // Si es la raíz
            if (string.Equals(raiz.Nombre, nombre, StringComparison.OrdinalIgnoreCase))
            {
                raiz = null;
                RefrescarTreeView();
                txtResultadosArbol.Text = "Se eliminó la raíz.";
                return;
            }

            bool eliminado = EliminarNodo(raiz, nombre);
            RefrescarTreeView();
            txtResultadosArbol.Text = eliminado ?
                $"Nodo \"{nombre}\" eliminado." :
                $"No se encontró el nodo \"{nombre}\".";
        }

        void btnBuscarNodo_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNodo.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                txtResultadosArbol.Text = "Escriba el nombre a buscar.";
                return;
            }

            if (raiz == null)
            {
                txtResultadosArbol.Text = "El árbol está vacío.";
                return;
            }

            var encontrado = BuscarNodo(raiz, nombre);
            txtResultadosArbol.Text = encontrado != null
                ? $"Nodo \"{nombre}\" encontrado."
                : $"Nodo \"{nombre}\" no encontrado.";
        }

        void btnPreorden_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                txtResultadosArbol.Text = "El árbol está vacío.";
                return;
            }

            List<string> nodos = new List<string>();
            Preorden(raiz, nodos);
            txtResultadosArbol.Text = "Preorden:\r\n" + string.Join(" -> ", nodos);
        }

        void btnPostorden_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                txtResultadosArbol.Text = "El árbol está vacío.";
                return;
            }

            List<string> nodos = new List<string>();
            Postorden(raiz, nodos);
            txtResultadosArbol.Text = "Postorden:\r\n" + string.Join(" -> ", nodos);
        }

        void btnPorNiveles_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                txtResultadosArbol.Text = "El árbol está vacío.";
                return;
            }

            List<string> nodos = new List<string>();
            PorNiveles(raiz, nodos);
            txtResultadosArbol.Text = "Por niveles:\r\n" + string.Join(" -> ", nodos);
        }

        // ================== RECORRIDOS ÁRBOL ==================

        void Preorden(NodoArbol n, List<string> lista)
        {
            if (n == null) return;
            lista.Add(n.Nombre);
            foreach (var h in n.Hijos)
                Preorden(h, lista);
        }

        void Postorden(NodoArbol n, List<string> lista)
        {
            if (n == null) return;
            foreach (var h in n.Hijos)
                Postorden(h, lista);
            lista.Add(n.Nombre);
        }

        void PorNiveles(NodoArbol n, List<string> lista)
        {
            Queue<NodoArbol> q = new Queue<NodoArbol>();
            q.Enqueue(n);
            while (q.Count > 0)
            {
                var x = q.Dequeue();
                lista.Add(x.Nombre);
                foreach (var h in x.Hijos)
                    q.Enqueue(h);
            }
        }

        // ================== LÓGICA DEL GRAFO ==================

        Vertice BuscarVertice(string nombre)
        {
            foreach (var v in vertices)
                if (string.Equals(v.Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                    return v;
            return null;
        }

        void ActualizarCombosVertices()
        {
            ComboBox[] combos = { cmbOrigen, cmbDestino, cmbOrigenRuta, cmbDestinoRuta };
            foreach (var cmb in combos)
            {
                cmb.Items.Clear();
                foreach (var v in vertices)
                    cmb.Items.Add(v.Nombre);
            }
        }

        void MostrarAdyacencias()
        {
            if (vertices.Count == 0)
            {
                txtAdyacencias.Text = "No hay vértices.";
                return;
            }

            string texto = "";
            foreach (var v in vertices)
            {
                texto += v.Nombre + ": ";
                if (v.Adyacentes.Count == 0)
                {
                    texto += "(sin conexiones)\r\n";
                }
                else
                {
                    List<string> conns = new List<string>();
                    foreach (var a in v.Adyacentes)
                        conns.Add($"{a.Destino.Nombre}({a.Peso})");
                    texto += string.Join(", ", conns) + "\r\n";
                }
            }
            txtAdyacencias.Text = texto;
        }

        bool EsConexo()
        {
            if (vertices.Count == 0) return false;
            HashSet<Vertice> visitados = new HashSet<Vertice>();
            Queue<Vertice> cola = new Queue<Vertice>();

            cola.Enqueue(vertices[0]);
            visitados.Add(vertices[0]);

            while (cola.Count > 0)
            {
                var v = cola.Dequeue();
                foreach (var a in v.Adyacentes)
                {
                    if (!visitados.Contains(a.Destino))
                    {
                        visitados.Add(a.Destino);
                        cola.Enqueue(a.Destino);
                    }
                }
            }

            return visitados.Count == vertices.Count;
        }

        void CalcularRutaMasCorta()
        {
            if (vertices.Count == 0)
            {
                txtRutaCorta.Text = "No hay vértices.";
                return;
            }
            if (cmbOrigenRuta.SelectedItem == null || cmbDestinoRuta.SelectedItem == null)
            {
                txtRutaCorta.Text = "Seleccione origen y destino.";
                return;
            }

            string origenNombre = cmbOrigenRuta.SelectedItem.ToString();
            string destinoNombre = cmbDestinoRuta.SelectedItem.ToString();

            var origen = BuscarVertice(origenNombre);
            var destino = BuscarVertice(destinoNombre);
            if (origen == null || destino == null)
            {
                txtRutaCorta.Text = "Origen o destino no válidos.";
                return;
            }

            var dist = new Dictionary<Vertice, int>();
            var prev = new Dictionary<Vertice, Vertice>();
            var noVisitados = new List<Vertice>(vertices);

            foreach (var v in vertices)
            {
                dist[v] = int.MaxValue;
                prev[v] = null;
            }
            dist[origen] = 0;

            while (noVisitados.Count > 0)
            {
                Vertice u = null;
                int mejor = int.MaxValue;
                foreach (var v in noVisitados)
                {
                    if (dist[v] < mejor)
                    {
                        mejor = dist[v];
                        u = v;
                    }
                }

                if (u == null || dist[u] == int.MaxValue)
                    break;

                noVisitados.Remove(u);

                foreach (var a in u.Adyacentes)
                {
                    int alt = dist[u] + a.Peso;
                    if (alt < dist[a.Destino])
                    {
                        dist[a.Destino] = alt;
                        prev[a.Destino] = u;
                    }
                }
            }

            if (dist[destino] == int.MaxValue)
            {
                txtRutaCorta.Text = "No existe ruta entre esos vértices.";
                txtDistanciaTotal.Text = "";
                return;
            }

            List<string> camino = new List<string>();
            var actual = destino;
            while (actual != null)
            {
                camino.Add(actual.Nombre);
                actual = prev[actual];
            }
            camino.Reverse();

            txtRutaCorta.Text = "Ruta: " + string.Join(" -> ", camino);
            txtDistanciaTotal.Text = dist[destino].ToString();
        }

        // ================== BOTONES GRAFO ==================

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEdificio.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                txtResultadoConexo.Text = "Escriba un nombre de edificio.";
                return;
            }

            if (BuscarVertice(nombre) != null)
            {
                txtResultadoConexo.Text = $"Ya existe un edificio llamado \"{nombre}\".";
                return;
            }

            var v = new Vertice(nombre);
            vertices.Add(v);
            lstEdificios.Items.Add(nombre);
            ActualizarCombosVertices();
            txtNombreEdificio.Clear();
            txtResultadoConexo.Text = "Edificio agregado.";
        }

        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedItem == null || cmbDestino.SelectedItem == null)
            {
                txtResultadoConexo.Text = "Seleccione origen y destino.";
                return;
            }

            string origenNombre = cmbOrigen.SelectedItem.ToString();
            string destinoNombre = cmbDestino.SelectedItem.ToString();
            int peso = (int)nudPeso.Value;

            if (origenNombre == destinoNombre)
            {
                txtResultadoConexo.Text = "Origen y destino deben ser distintos.";
                return;
            }

            var o = BuscarVertice(origenNombre);
            var d = BuscarVertice(destinoNombre);
            if (o == null || d == null)
            {
                txtResultadoConexo.Text = "Origen o destino no válidos.";
                return;
            }

            o.Adyacentes.Add(new Arista(d, peso));
            d.Adyacentes.Add(new Arista(o, peso)); // grafo no dirigido

            lstConexiones.Items.Add($"{o.Nombre} - {d.Nombre} ({peso})");
            txtResultadoConexo.Text = "Conexión agregada.";
        }

        private void btnMostrarAdyacencias_Click(object sender, EventArgs e)
        {
            MostrarAdyacencias();
        }

        private void btnEsConexo_Click(object sender, EventArgs e)
        {
            if (vertices.Count == 0)
            {
                txtResultadoConexo.Text = "No hay vértices.";
                return;
            }

            txtResultadoConexo.Text = EsConexo()
                ? "El grafo es conexo."
                : "El grafo NO es conexo.";
        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            CalcularRutaMasCorta();
        }
    }

    // ====== CLASES DE ÁRBOL ======
    public class NodoArbol
    {
        public string Nombre;
        public List<NodoArbol> Hijos = new List<NodoArbol>();

        public NodoArbol(string nombre)
        {
            Nombre = nombre;
        }
    }

    // ====== CLASES DE GRAFO ======
    public class Arista
    {
        public Vertice Destino;
        public int Peso;

        public Arista(Vertice d, int p)
        {
            Destino = d;
            Peso = p;
        }
    }

    public class Vertice
    {
        public string Nombre;
        public List<Arista> Adyacentes = new List<Arista>();

        public Vertice(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString() => Nombre;
    }


}
