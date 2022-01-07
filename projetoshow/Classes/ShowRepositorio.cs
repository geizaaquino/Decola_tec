using System;
using System.Collections.Generic;
using DIO.Show.Interfaces;

namespace DIO.Show
{
	public class ShowRepositorio : IRepositorio<Show>
	{
        private List<Show> listaShow = new List<Show>();
		public void Atualiza(int id, Show objeto)
		{
			listaShow[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaShow[id].Excluir();
		}

		public void Insere(Show objeto)
		{
			listaShow.Add(objeto);
		}

		public List<Show> Lista()
		{
			return listaShow;
		}

		public int ProximoId()
		{
			return listaShow.Count;
		}

		public Show RetornaPorId(int id)
		{
			return listaShow[id];
		}
	}
}