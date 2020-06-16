# specflow-example
My SpecFlow playground in Visual Studio Code (Mac)

## Setup docker to run chromedriver
```
docker pull selenium/standalone-chrome
docker run --name=browser-chrome -d -p 4444:4444 selenium/standalone-chrome:latest
docker stop browser-chrome 
```
