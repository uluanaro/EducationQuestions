namespace EducationQuestions.Presenters.Controllers;

public record UpdateQuestionDto(string Title, string Body, Guid[] TagIds);