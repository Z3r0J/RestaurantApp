using System;

namespace BusinessLayer
{
    public sealed class RepositorioOrdenes
    {
        public static RepositorioOrdenes Instancia { get; } = new RepositorioOrdenes();

        public int p = 2;
       public int s = 0;
        private RepositorioOrdenes()
        {

        }
    }
}
