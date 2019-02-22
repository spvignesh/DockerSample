1. Create a Sample Console Application (.NetCore) in VS2017
2. Go to Cmd --> open project location and run the below steps 
	1. dotnet restore (Make sure .NetCore 2.x is installed)
	2. dotnet build (you can also build via VS2017)
	3. dotnet publish
3. Create Docker Image by running the following cmd in the project folder,
	-> docker build -t myfirstimage:v1 .
	-> docker images -a (check the image is available)
4. Run the app in docker
	-> docker run myfirstimage:v1