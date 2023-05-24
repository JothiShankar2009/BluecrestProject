Feature: As a user I want to book an appointment for Female Cancer Risk(Over 40s)

Background:
Given user navigate to url

@TestersTalk
Scenario: Book an appoinment for female cancer risk over 40s

When Click on the Health Assessment
And Click on the female cancer risk
And Validate user landed in the cancer risk female page
And Click on the book now button
And User will be landed on clinic search page successfully
And User enter location in text box
And Choose location which nearest you
And choose date
And choose time
And Click on the confirm button
Then User will be landing on the order summary page
And Click on the continue button 
Then User will be landed in the personal details page successfully.


#Example for Scenario oultline

Scenario Outline: As someone wants to Register
	Given User on the personal details page
	When I submit the form with the following details "<Tilte>", "<Firstname>", "<Lastname>", "<Day>", "<Month>", "<Year>", "<Sex>", "<Emailaddress>", "<Confirmemailaddress>", "<Phonenumber>", "<Password>", "<Confirmpassword>", "<Postcode>", "<Address1>", "<Town>", "<Country>"
	And Select You must agree to the Bluecrest Terms & Conditions to continue checkbox
	And Select You must agree to Bluecrest Privacy Policy to continue checkbox
	And The deatails should be displayed on my registration page
	And Click on Continue button
	Then user should be able to see orderpayment page
Example:
| Title |  | FirstName |  | Lastname |  | Day |  | Month |  | Year |  | Sex    |  | Emailaddress         |  | Confirmemailaddress   |  | Phonenumber |  | Password |  | Confirmpassword |  | Postcode |  | Address1              |  | Town     |  | Country         |
| Mrs   |  | Marry     |  | Johnv    |  | 09  |  | 08    |  | 1980 |  | Feamle |  | john.marry@gmail.com |  | john.marry@gmaiol.com |  | 07895641235 |  | Book123% |  | Book123%        |  | Bn13 1FL |  | 1, Quicksilver street |  | Worthing |  | Unkited Kingdon | 



Feature: As a user I want to book an appointment for male Cancer Risk(Over 40s)

Background:
Given user navigate to url

@TestersTalk
Scenario: Book an appoinment for male cancer risk over 40s

When Click on the Health Assessment
And Click on the female cancer risk
And Validate user landed in the cancer risk female page
And Click on the book now button
And User will be landed on clinic search page successfully
And User enter location in text box
And Choose location which nearest you
And choose date
And choose time
And Click on the confirm button
Then User will be landing on the order summary page
And Click on the continue button 
Then User will be landed in the personal details page successfully.


