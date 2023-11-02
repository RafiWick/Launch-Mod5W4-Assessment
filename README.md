# Week 4 Assessment

In this week's assessment, imagine you have been scheduled for a half-day interview.  The first part of the interview is a technical challenge!  You will have 90 minutes to complete a technical challenge and provide some reflection.

## Technical Challenge (10 points)

### Setup
* Fork and clone this repository.
* Click on 'Planets' in the navbar and make sure you see the 8 planets of our solar system.
* Checkout a new branch and complete the following task.

Your task is to add the explored planets of the galaxy 'Far Far Away' (all of the planets in the star wars films, as outlined in the SWAPI API).

We would like you to get the necessary data by consuming the [SWAPI](https://swapi.dev/) API.  A successful mission will:
* Use HttpClient to make an API call to SWAPI when a request comes in (to get the most up-to-date information!)
* Display the known planets of the Far Far Away Galaxy on a view.
  * Be sure to include the name and population of each planet.

Outside of those requirements, you may choose to add any additional functionality!

When finished, create a PR and include your answers to the reflection questions below in a PR comment.

## Reflection Questions (6 points)
* What about this challenge was most difficult for you?

  the most dificult part for me is getting the Json document into a usable format, it is coming back with some extra information at the begining and I cant seem to isolate the list of planets.
* Highlight one peice of code that you wrote that you are especially proud of.

`for (int i=0; i < 6; i++){
var url = string.Format($"/api/planets/?page={i + 1}");
var response = await _client.GetAsync(url);`

I am especially proud of this bit of code because it will grab all of the planets from all 6 pages
* What would you do next, if we gave you another hour?


If I had more time I would spend it figuring out how to get the data out of the Json document and into the SWPlanet model.
## Rubric

This assessment has a total of 16 points.  Earning 10 or more points is a pass.

For the technical challenge, we are looking for:
* 2 Points - successful creation of a HTTPClient
* 2 Points - correct URL configuration
* 1 point - making a get request
* 2 points - turning the response into a list of planets
* 3 points - getting the requested planets showing up on a page

