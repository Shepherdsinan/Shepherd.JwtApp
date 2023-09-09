using MediatR;

namespace Shepherd.JwtApp.Back;
public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
{

}
