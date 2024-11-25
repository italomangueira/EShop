using EShop.Models.DTOs;

namespace EShop.Web.Services;

public interface IGerenciaProdutosLocalStorageService
{
    Task<IEnumerable<ProdutoDto>> GetCollection();
    Task RemoveCollection();
}
