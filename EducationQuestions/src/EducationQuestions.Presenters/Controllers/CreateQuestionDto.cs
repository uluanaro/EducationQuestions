namespace EducationQuestions.Presenters.Controllers;

public record CreateQuestionDto(string Title, string Body, Guid UserId, Guid[] TagIds);