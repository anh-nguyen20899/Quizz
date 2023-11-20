
namespace Quizz.Api.Repository
{
    public interface IMemoryQuestionRepository
    {
        Task<Item> GetSingleQuestionAsync(Guid Id);
        Task<IEnumerable<Item>> GetQuestionsAsync();
        Task CreateQuestionAsync(Item item);
        Task UpdateQuestionAsync(Item item);
        Task DeleteQuestionAsync(Guid id);

    }
}