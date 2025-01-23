using Microsoft.EntityFrameworkCore;
using Primeira_API.Data;
using Primeira_API.Models;

namespace Primeira_API.Services.Autor
{
    public class AutorServices : IAutorInterface
    {
        private readonly AppDbContext _context;
        public AutorServices(AppDbContext context)
        {
            _context = context;

        }
        public Task<ResponseModel<AutorModel>> BuscarAutorPorID(int IdAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorIDLivro(int IdLivro)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    }
}
