# ColligoTest
Test Assignment for Colligo

Project containing a unit tested API caller to Eventful.com

## Comments
I found the api responses did not map to the documentation as perfectly as one would hope. I took this as a sign that any calls the API cannot really be trusted- there's no way to know if a null assignment was a problem in the code, or if the API itself returned a null value.

Therefore, I concentrated testing against what's forming the query, ensuring it maps to documentation correctly, as well as ensuring that properly formed JSON maps to the deserialzed response object. 

The only major issue I had was that I accidentally built Events/Get instead of Venues/Get... #Whoops #ReadTheRequirementsCarefully
 ... Thankfully it wasn't too difficult to add a Venues/Get call, due to the way I had built the service. So technically I've gone above and beyond? 
 
It's not finished, strictly speaking. I would want to convert the raw deserialized objects into more common-sense objects, such as date strings. 

## Unit Tests
I've been running the unit tests through the Visual Studio Nunit runner plugin. If you don't already have it, or it's not included with the project, you might have to NuGet it. Then just run through Ctrl+R, Ctrl+A. 

As mentioned, I concentrated on ensuring each parameter being formed in the query was what was being expected by the API, as well as the full query string itself was properly formed. On the response side, I built a quick and dirty json builder to simulate the expected JSON. Since I can't trust the API, I decided to test the deserializer against the json being expected. 

This approach meant the total unit test run duration was fairly short, as I had isolated the calls to the actual API to a few select unit tests. If I had more time, I'd think about a more robust way to test the actual response to the expected response. 

## Code
The code could be cleaned up a bit more. I was changing the design of the implementation as I was writing the implementation. This means I expect some classes to have duplicate methods, or unused/changed variables. It would be a fairly trivial matter going through and refactoring these items out. 

While I try to concentrate on designing implementation first, so I don't run into this problem, it's much harder when you're building the project from scratch. It's much easier to write clean code to an existing pattern, than it is to design the pattern from scratch.

All in all, I'm pretty happy with where I'm at with this project. It's a good indication of my current skill level, and it works. It calls the API and converts the response into something usable by the rest of the program. 
