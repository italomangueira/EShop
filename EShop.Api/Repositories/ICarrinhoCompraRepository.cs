using EShop.Api.Entities;
using EShop.Models.DTOs;

namespace EShop.Api.Repositories;

public interface ICarrinhoCompraRepository
{
    Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto);

    Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAtualizaQuantidadeDto 
        carrinhoItemAtualizaQuantidadeDto);

    Task<CarrinhoItem> DeletaItem(int id);

    Task<CarrinhoItem> GetItem(int id);

    Task<IEnumerable<CarrinhoItem>> GetItens(string usuarioId);
}
