class Question {
    constructor(questionText, correctAnswer, wrongAnswers) {
        this.questionText = questionText;
        this.correctAnswer = correctAnswer;
        this.wrongAnswers = wrongAnswers;
    }

    getQuestionText() {
        return this.questionText;
    }

    getCorrectAnswer() {
        return this.correctAnswer;
    }

    getWrongAnswers() {
        return this.wrongAnswers;
    }
}

module.exports = Question;