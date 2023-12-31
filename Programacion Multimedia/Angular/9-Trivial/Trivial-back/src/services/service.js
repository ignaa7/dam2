const Question = require('../classes/question.js');

class Service {
    constructor() {
        this.questions = [
            new Question('¿Qué forma tiene un transportador, usado para medir y dibujar ángulos?', 'Semicircular', ['Hexagonal', 'Rectangular', 'Triangular']),
            new Question('¿Qué ingrediente se usa en la comida vegana como sustituto de la clara de huevo en ciertas recetas?', 'Agua de garbanzos', ['Semillas de uva aplastadas', 'Almidón de patata', 'Chicharrones derretidos']),
            new Question('¿Cuál de estas es una forma de artritis causada por un exceso de cristales de ácido úrico en los tejidos del cuerpo?', 'Gota', ['Lágrima', 'Torrente', 'Chorro']),
            new Question('En la escala de Fahrenheit, ¿cuál es el punto de fusión del agua?', '32 °F', ['0 °F', '10 °F', '24 °F']),
            new Question('¿Qué flor lleva el nombre de un joven hermoso de la mitología griega?', 'Narciso', ['Prímula', 'Mimulus', 'Hibisco']),
            new Question('¿Quién escribió la novela "El regreso del nativo"?', 'Thomas Hardy', ['George Eliot', 'Thomas Hughes', 'Charles Dickens']),
            new Question('¿Cuál de estas personas estaría muy interesada en un talpaire?', 'Pescador', ['Coleccionista de mariposas', 'Jardinero', 'Ornitólogo']),
            new Question('¿A qué tipo de tienda llevarías una "receta"?', 'Farmacia', ['Carnicería', 'Satrería', 'Panadería']),
            new Question('¿Qué término de ballet significa "un baile para dos"?', 'Pas de deux', ['Pas de trois', 'Pas de quatre', 'Pas de cinq']),
            new Question('¿En qué país se establecieron los Contras como fuerza guerrillera en la década del 80?', 'Nicaragua', ['México', 'Egipto', 'Chile'])
        ];
    }

    getQuestion() {
        let randomNumber = Math.floor(Math.random() * this.questions.length);
        let question = this.questions[randomNumber];

        return {
            questionText: question.getQuestionText(),
            correctAnswer: question.getCorrectAnswer(),
            wrongAnswers: question.getWrongAnswers()
        };
    }
}

module.exports = Service;