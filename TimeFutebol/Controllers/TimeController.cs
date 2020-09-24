using TimeFutebol.Models;
using TimeFutebol.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //CRUD - OPERACOES BASICAS -> CRICAO,REMOCAO,ATUALIZAO E BUSCA
    public class TimeController : ControllerBase
    {
        private TimeRepository _repository;
        public TimeController() {
            _repository = new TimeRepository();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(_repository.ListarTodosTimes());
        }
        //GET - BUSCAR ALGO - IR LA NO BANCO DE DADOS E SELECIONAR OS REGISTROS
      
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
           
        {
            var timeTitulos = _repository.BuscarTimePorId(id);
            if (timeTitulos == null) {
                return NotFound();
            }
            //buscar la no bando de dados os dados do aluno id
            return Ok(timeTitulos);
        }
        [HttpPost]
        //POST - CRIAR -> INSERIR UMA INFORMAÇÃO NO BANCO DE DADOS
        public async Task<IActionResult> Post(Time timao)
        {
         
            _repository.InserirTime(timao);
            return Ok("Time criado com sucesso!");
        }

        [HttpPut]
        //PUT - ATUALIZAR -> MODIFICAR UMA INFORMAÇÃO NO BANCO DE DADOS
        public async Task<IActionResult> Put(int id, Time timao) {
            if (string.IsNullOrEmpty(timao.nome))
            {
                return BadRequest("Nome do Time está em branco, favor preencher!");
            }


            return Ok("Categoria encontrada");
        }
        [HttpDelete]
        //DELETE - REMOVER -> RETIRAR UMA INFORMAÇÃO NO BANCO DE DADOS
        public async Task<IActionResult> Delete(int id) {
            if (id>0)
            {
                return Ok("Categoria deletada com sucesso!");
            }
            return BadRequest("HAHA, o que já foi cadastrado nunca será deletado");
        }



    }

    
}
