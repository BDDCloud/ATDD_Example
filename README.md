Prerequisites:

We will be implementing feature(s) using acceptance test driven development (ATDD). 

Our production code will be html + javascript and some of it is already written under <Repo>\Calculator.Web.

For acceptance tests we will use Selenium WebDriver which supports:

java
csharp
python
ruby
javascript (node)

For unit tests we will be using Jasmine which is already setup under <Repo>\ATDD_Example\JS_Specs.

I will be using visual studio + c# + chrome for acceptance tests, but if you don't have that installed, probably use the platform / language / browser combination already installed that you are most comfortable with.

If you are using C# for acceptance tests, you can reuse the existing infrastructure in the acceptance test project. That code is already starting the mongoose server. However, if you are starting from scratch, start the mongoose server manually once:

Use the mongoose web server. There is a copy in the tools folder. Or you can download it from: https://code.google.com/p/mongoose/

tools\mongoose-free-5.2.exe

Usage: 
tools\mongoose-free-5.2.exe -document_root <path_to_your_website> -listening_port <free_port>

Example, on my machine it would be:
open cmd.exe
tools\mongoose-free-5.2.exe C:\Projects\ATDD_Example\Calculator.Web -listening_port 9999

To test that it works, see that this loads http://localhost:9999/index.html

We will be using webdriver. If you are using visual studio/c#/chrome the acceptance test project should work for you. Otherwise you need to go download your appropriate webdriver for language AND a browser specific server. 

For example, for visual studio I had to do two things: 1) package-install Selenium.WebDriver (nuget package installer), and 2) download chromedriver.exe from http://docs.seleniumhq.org/download/ under the section "Third party Browser Drivers". Following the link for Chrome, I downloaded ChromeDriver from http://chromedriver.storage.googleapis.com/2.9/chromedriver_win32.zip. Chromedriver.exe 2.9 is in this repo already.

The Selenium.WebDriver (for C#) is the thin wrapper to a selenium server. Chromedriver.exe is an example of a selenium server for Chrome browser. But you may choose to download internetexplorerdriver.exe for example if you want to use that instead.

For languages other than C# you can go to http://docs.seleniumhq.org/download/ and find your language under Selenium Client & WebDriver Language Bindings.
