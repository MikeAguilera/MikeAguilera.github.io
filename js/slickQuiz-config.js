// Setup your quiz text and questions here

// NOTE: pay attention to commas, IE struggles with those bad boys

var quizJSON = {
    "info": {
        "name":    "Test Your Knowledge of Lingala!!",
        "main":    "<p>TLingala (Ngala) is a Bantu language spoken throughout the northwestern part of the Democratic Republic of the Congo and a large part of the Republic of the Congo, as well as to some degree in Angola and the Central African Republic. It has over 10 million speakers.</p>",
        "results": "<h5>Learn More</h5><p>Click on the following link to go to the Lingala Wikipedia page</p>",
        "level1":  "DRC Ready",
        "level2":  "DRC Contender",
        "level3":  "DRC Amateur",
        "level4":  "DRC Newb",
        "level5":  "Stay in school, kid..." // no comma here
    },
    "questions": [
        { // Question 1 - Multiple Choice, Single True Answer
            "q": "What is the Lingala phrase for apple?",
            "a": [
                {"option": "Mbuma ya pomme",    "correct": true},
                {"option": "Mbuma ya lait",     "correct": false},
                {"option": "Mbuma ya fromage",  "correct": false},
                {"option": "Mbuma ya manzana",     "correct": false} // no comma here
            ],
            "correct": "<p><span>That's right!</span></p>",
            "incorrect": "<p><span>Uhh no.</span> Better luck next time <em></em></p>" // no comma here
        },
        { // Question 2 - Multiple Choice, Multiple True Answers, Select Any
            "q": "What is the Lingala phrase for Baby?",
            "a": [
                {"option": "Wanna Poke",   "correct": false},
                {"option": "Mwana Moke",   "correct": true},
                {"option": "Mwana Pomme",  "correct": false},
                {"option": "Wanna Moke",   "correct": false} // no comma here
            ],
            "select_any": true,
            "correct": "<p><span>Nice!</span> Yes! That is correct. Baby in Lingala ia Mwana Moke!</p>",
            "incorrect": "<p><span>Hmmm.</span> Nice try. </p>" // no comma here
        },
        { // Question 3 - Multiple Choice, Multiple True Answers, Select All
            "q": "What is the Lingala phrase for Bank?",
            "a": [
                {"option": "Pokwa",  "correct": false},
                {"option": "Eyano",  "correct": false},
                {"option": "Etabe",  "correct": false},
                {"option": "Emobobelo Misolo",  "correct": true} // no comma here
            ],
            "correct": "<p><span>Brilliant!</span> You're seriously a genius.</p>",
            "incorrect": "<p><span>Not Quite.</span> But nice try.</p>" // no comma here
        },
        { // Question 4
            "q": "What is the Lingala phrase for Boy?",
            "a": [
                {"option": "Maswa",    "correct": false},
                {"option": "Mwana mobali", "correct": true},
                {"option": "Lipa",      "correct": false},
                {"option": "Manteka",   "correct": false} // no comma here
            ],
            "correct": "<p><span>Holy bananas!</span> I didn't actually expect you to know that! Correct!</p>",
            "incorrect": "<p><span>Fail.</span> Sorry. You lose.</p>" // no comma here
        },
        { // Question 5
            "q": "What is the Lingala phrase for Bus?",
            "a": [
                {"option": "Mokanda",    "correct": false},
                {"option": "Motuka",     "correct": true} // no comma here
            ],
            "correct": "<p><span>Good Job!</span> You must be very observant!</p>",
            "incorrect": "<p><span>ERRRR!</span></p>" // no comma here
        }, 
        { // Question 6 - Multiple Choice, Single True Answer
            "q": "What is the Lingala phrase for Mommy?",
            "a": [
                {"option": "Mama",    "correct": true},
                {"option": "Mbuma",     "correct": false},
                {"option": "Mai",  "correct": false},
                {"option": "Mwama",     "correct": false} // no comma here
            ],
            "correct": "<p><span>That's right!</span></p>",
            "incorrect": "<p><span>Uhh no.</span> Better luck next time <em></em></p>" // no comma here
        },
        { // Question 7 - Multiple Choice, Multiple True Answers, Select Any
            "q": "What is the Lingala phrase for Daddy?",
            "a": [
                {"option": "Papi",   "correct": false},
                {"option": "Papa",   "correct": true},
                {"option": "Mwana",  "correct": false},
                {"option": "Moke",   "correct": false} // no comma here
            ],
            "select_any": true,
            "correct": "<p><span>Nice!</span> Yes! That is correct. Baby in Lingala ia Mwana Moke!</p>",
            "incorrect": "<p><span>Hmmm.</span> Nice try. </p>" // no comma here
        },
        { // Question 8 - Multiple Choice, Multiple True Answers, Select All
            "q": "What is the Lingala phrase for Daughter?",
            "a": [
                {"option": "Pokwa",  "correct": false},
                {"option": "Mwana Mobali",  "correct": false},
                {"option": "Mwana Mwasi",  "correct": true},
                {"option": "Emobobelo Misolo",  "correct": false} // no comma here
            ],
            "correct": "<p><span>Brilliant!</span> You're seriously a genius.</p>",
            "incorrect": "<p><span>Not Quite.</span> But nice try.</p>" // no comma here
        },
        { // Question 9
            "q": "What is the Lingala phrase for Son?",
            "a": [
                {"option": "Maswa",    "correct": false},
                {"option": "Mwana mobali", "correct": true},
                {"option": "Lipa",      "correct": false},
                {"option": "Manteka",   "correct": false} // no comma here
            ],
            "correct": "<p><span>Holy bananas!</span> I didn't actually expect you to know that! Correct!</p>",
            "incorrect": "<p><span>Fail.</span> Sorry. You lose.</p>" // no comma here
        },
        { // Question 10
            "q": "What is the Lingala phrase for Love You?",
            "a": [
                {"option": "Lait",    "correct": false},
                {"option": "Motuka",    "correct": false},
                {"option": "Mokanda",    "correct": false},
                {"option": "Alingi",     "correct": true} // no comma here
            ],
            "correct": "<p><span>Good Job!</span> You must be very observant!</p>",
            "incorrect": "<p><span>ERRRR!</span></p>" // no comma here
        } // no comma here
    ]
};
