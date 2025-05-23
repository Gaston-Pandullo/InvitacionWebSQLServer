using Invitacion.Datos;
using Invitacion.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invitacion.Negocio
{
    public class ServicioInvitado
    {
        private readonly AppDbContext _dbContext;
        public ServicioInvitado(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Invitado>> BuscarInvitados(string nombreInvitado)
        {
            List<Invitado> listaInvitados = await _dbContext.Invitados
                .Where(invitado => invitado.NombreCompleto.Contains(nombreInvitado))
                .ToListAsync();
            return listaInvitados;
        }

        public async Task confirmacionAsistencia(int invtadoId)
        {
            // Se busca segun la clave primaria, en este caso, el id:
            var invitado = await _dbContext.Invitados.FindAsync(invtadoId);

            if (invitado != null)
            {
                invitado.Confirmado = true;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
