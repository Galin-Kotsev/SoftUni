function solve(input) {

    input = input.slice(", ");

    let dictionary = {};

   input.forEach((jsonString) => {
    const term = JSON.parse(jsonString);
    dictionary = Object.assign(dictionary,term)
   });

   const sortedDictionaryTerms = Object.keys(dictionary).sort();

   sortedDictionaryTerms.forEach((term) => {
    console.log(`Term: ${term} => Definition: ${dictionary[term]}`)
   });
}


solve([
    '{"Cup":"A small bowl-shaped container for drinking from, typically having a handle"}',
    '{"Cake":"An item of soft sweet food made from a mixture of flour, fat, eggs, sugar, and other ingredients, baked and sometimes iced or decorated."}',
    '{"Watermelon":"The large fruit of a plant of the gourd family, with smooth green skin, red pulp, and watery juice."} ',
    '{"Music":"Vocal or instrumental sounds(or both) combined in such a way as to produce beauty of form, harmony, and expression of emotion."} ',
    '{"Art":"The expression or application of human creative skill and imagination, typically in a visual form such as painting or sculpture, producing works to be appreciated primarily for their beauty or emotional power."} '
])