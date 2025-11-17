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
        NodoArbol raiz; // raíz del árbol

        public Form1()
        {
            InitializeComponent();

            // Asegúrate de que estos eventos estén conectados
            btnInsertarNodo.Click += btnInsertarNodo_Click;
            btnEliminarNodo.Click += btnEliminarNodo_Click;
            btnBuscarNodo.Click += btnBuscarNodo_Click;
            btnPreorden.Click += btnPreorden_Click;
            btnPostorden.Click += btnPostorden_Click;
            btnPorNiveles.Click += btnPorNiveles_Click;
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

        // ================== BOTONES ==================

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

        // ================== RECORRIDOS ==================

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
    }

    public class NodoArbol
    {
        public string Nombre;
        public List<NodoArbol> Hijos = new List<NodoArbol>();

        public NodoArbol(string nombre)
        {
            Nombre = nombre;
        }
    }

    
}
