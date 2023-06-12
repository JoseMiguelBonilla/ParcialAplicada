using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ParcialAplicada.DAL;
using ParcialAplicada.Models;

namespace ParcialAplicada.BLL
{
    public class LibrosBLL
    {
        private readonly Contexto _contexto;

        public LibrosBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Libros Libros)
        {
            if (!Existe(Libros.LibroId))
                return Insertar(Libros);
                else 
                return Modificar(Libros);
        }

        public bool Existe (int LibroId)
        {
            return _contexto.Libros.Any(s => s.LibroId == LibroId);
        }

        private bool Insertar (Libros Libros)
        {
            _contexto.Libros.Add(Libros);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }

        private bool Modificar(Libros Libros)
        {
            _contexto.Update(Libros);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;  

        }

        public bool Eliminar (Libros Libros)
        {
            _contexto.Libros.Remove(Libros);
            int cantidad = _contexto.SaveChanges();

            return cantidad > 0;
        }

        public Libros Buscar ( int LibroId)
        {
            return _contexto.Libros.AsNoTracking().FirstOrDefault( s => s.LibroId == LibroId);
        }

        public List <Libros> GetList(Expression<Func<Libros, bool>> Criterio)
        {
            return _contexto.Libros
            .Where(Criterio)
            .AsNoTracking()
            .ToList();
        }

}
}