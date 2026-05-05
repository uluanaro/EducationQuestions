namespace EducationQuestions.Presenters.Controllers;

public record GetQuestionDto(string Search, Guid[] TagIds, int Page, int Limit);