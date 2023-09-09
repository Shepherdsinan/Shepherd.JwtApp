using MediatR;

namespace Shepherd.JwtApp.Back;
public class GetCategoriesQueryRequest : IRequest<List<CategoryListDto>>
{

}
