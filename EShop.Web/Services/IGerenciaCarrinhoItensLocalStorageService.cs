using EShop.Models.DTOs;

namespace EShop.Web.Services;

public interface IGerenciaCarrinhoItensLocalStorageService
{
    Task<List<CarrinhoItemDto>> GetCollection();
    Task SaveCollection(List<CarrinhoItemDto> carrinhoItensDto);
    Task RemoveCollection();
}
