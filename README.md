Features...

Feature: Divide two integers

Given I enter first number <first_number>
And I enter second number <second_number>
When I divide
Then I see answer is <expected_answer>
And I see first number is <expected_first_number>
And I see second number is <expected_second_number>

Examples:
| first_number | second_number | expected_answer | expected_first_number | expected_second_number |
| 35 | 7 | 5 | "" | "" |
| -35 | 7 | -5 | "" | "" |
| 35 | -7 | -5 | "" | "" |
| -35 | -7 | 5 | "" | "" |
| 35 | 0 | Error | "" | "" |

Feature: Validation

Scenario: First number blank
Given I enter second number 7
When I divide
And I see validation "first number blank""
And I see answer is ""
And I see first number is ""
And I see second number is 7


Scenario: Second number blank
Given I enter first number 35
When I divide
And I see validation "second number blank""
And I see answer is ""
And I see first number is 35
And I see second number is ""


Scenario: Both numbers blank
When I divide
And I see validation "first number blank""
And I see validation "second number blank"
And I see answer is ""
And I see first number is ""
And I see second number is ""

Scenario: First number not a number
Given I enter first number "asdf""
And I enter second number 7
When I divide
And I see validation "asdf not a number"
And I see answer is ""
And I see first number is "asdf""
And I see second number is 7

Scenario: First number not a number
Given I enter first number <first_number>
And I enter second number <second_number>
When I divide
And I see validation <expected_validation_one>
And I see validation <expected_validation_two>
And I see answer is <expected_answer>
And I see first number is <expected_first_number>
And I see second number is <expected_second_number>


Scenario: Second number not a number
Given I enter first number 35
And I enter second number "qwer""
When I divide
And I see validation "qwer is not a number"
And I see answer is ""
And I see first number is 35
And I see second number is "qwer"

Scenario: Both numbers not a number
Given I enter first number "asdf""
And I enter second number "qwer""
When I divide
And I see validation "asdf is not a number"
And I see validation "qwer is not a number"
And I see answer is ""
And I see first number is "asdf"
And I see second number is "qwer"


Scenario: First number blank, second number not a number
Given I enter second number "qwer""
When I divide
And I see validation "first number blank"
And I see validation "qwer is not a number"
And I see answer is ""
And I see first number is ""
And I see second number is "qwer"

Scenario: First number not a number, second number blank
Given I enter first number "asdf""
When I divide
And I see validation "asdf is not a number"
And I see validation "second number blank"
And I see answer is ""
And I see first number is "asdf"
And I see second number is ""


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

tools\mongoose\mongoose-free-5.2.exe

Usage: 
tools\mongoose\mongoose-free-5.2.exe -document_root <path_to_your_website> -listening_port <free_port>

Example, on my machine it would be:
open cmd.exe
tools\mongoose\mongoose-free-5.2.exe -document_root C:\Projects\ATDD_Example\Calculator.Web -listening_port 9999

To test that it works, see that this loads http://localhost:9999/index.html

We will be using webdriver. If you are using visual studio/c#/chrome the acceptance test project should work for you. Otherwise you need to go download your appropriate webdriver for language AND a browser specific server. 

For example, for visual studio I had to do two things: 1) package-install Selenium.WebDriver (nuget package installer), and 2) download chromedriver.exe from http://docs.seleniumhq.org/download/ under the section "Third party Browser Drivers". Following the link for Chrome, I downloaded ChromeDriver from http://chromedriver.storage.googleapis.com/2.9/chromedriver_win32.zip. Chromedriver.exe 2.9 is in this repo already.

The Selenium.WebDriver (for C#) is the thin wrapper to a selenium server. Chromedriver.exe is an example of a selenium server for Chrome browser. But you may choose to download internetexplorerdriver.exe for example if you want to use that instead.

For languages other than C# you can go to http://docs.seleniumhq.org/download/ and find your language under Selenium Client & WebDriver Language Bindings.
