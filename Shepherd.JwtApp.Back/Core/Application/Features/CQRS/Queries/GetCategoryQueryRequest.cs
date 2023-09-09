using MediatR;

namespace Shepherd.JwtApp.Back;
public class GetCategoryQueryRequest : IRequest<CategoryListDto?>
{
    public int Id { get; set; }

    public GetCategoryQueryRequest(int id)
    {
        Id = id;
    }
}
