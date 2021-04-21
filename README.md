# Flexioncodereview
## Purpose
This project is intended to provide unit conversion functions as well as provide functionality to verify that current
conversions are accurate. 
## Considerations
This is a free to use applications under the GNU public license.
## Assumptions
The existance of this application assumes that a build vs buy analysis has already been performed, and to build was the decision.

## Project Composition
This is a Dotnet 5 (Notnet Core) MVC API application
The front end is Angular and Bootstrap
The project is docker-enabled 
This project uses Nunit for unit tests on the backend and Jasmine/Karma for Angular8 front-end unit tests.

## ToDo/Next Steps 
API IAM Oauth2 for API
Add API security and request throttling to prevent abuse
OIDC for the front end (presumably with the "school's" Identity Provider)
Add validation for numerical values
Precent API calls for unit conversions of the same type EG: inches to inches
Hook up the logging interface
Relational Database for UOM, types, and conversion formulas
Add Azure Front Door for load balancing and DDoS protection

## Setup/Installation
To run the project in development mode you will need NPM with the angularCli 
```npm install angularcli --global```
This project uses docker so full test integration you will need docker desktop or some form of container management (docker, podman, kuberetes, openshift, etc)
This project is writen with .Net Core so you will need the dotnet 5 runtime.
The dotnet runtime can be downloaded for all major platforms here:
```
https://www.microsoft.com/net/download/dotnet-core/5.0
```
And this can be installed by following the instructions at:
```
https://docs.microsoft.com/en-us/dotnet/core/linux-prerequisites?tabs=netcore5x
```

## Comments
I did NOT use TDD for this project (probably should have though in retrospect) because the requirements and  pass/fail criteria were clear from the beginning
Initially the project was nodejs and Angular but I feel that MVC API is more enterprise ready than Express. I pivoted there.

### Challenges / Retro
Had trouble finding a docker hub file that supports Angular AND Dotnet.
Adding the docker file too early caused the builds to start taking a LONG time
I had to stop and start many times do to real life and phone calls from recruiters so I ended up not committing as often as I prefer.
``` git commit -m 'just to prove I know how, lol' ```

### Developer Notes
While i was waiting on the first publish to push to azure, my Crypto portfolio went down 18.55% - Lesson: always sell tentative positions before you stop paying attention

