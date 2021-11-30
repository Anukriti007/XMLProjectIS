                                                                         **MOVIE RECOMMENDATION**

![MicrosoftTeams-image](https://user-images.githubusercontent.com/90084383/140229869-7ca45c4f-bcdb-4a42-b3d1-1f158f25d1ab.png)
________________________________________
**Introduction**

BingWatch.com lets you discover Top 250 Movies and TV Shows alongwith Top 15 Breweries and Top 15 Property listings in Chicago.

•	Search movie by Title

•	Search TV Show by Title

•	Details regarding Movie poster, Movie Title, Release year, IMDB Ratings, IMDB Count will be displayed.

•	Display list of Top 15 Breweries

•	Display list of Top 15 Property listings in Chicago.

________________________________________

**Data Feeds**

Dataset of 250 movies: https://raw.githubusercontent.com/Anukriti007/XMLProjectIS/master/Top250Movies.json

Dataset of 250 TV Shows: https://raw.githubusercontent.com/Anukriti007/XMLProjectIS/master/Top250TVShows.json

Dataset of Chicago Property listings: https://realestate20211125150037.azurewebsites.net/HousingRaw

Dataset of Breweries: https://breweryarc.azurewebsites.net/breweryentire
________________________________________
**Functional Requirements**:

List movie cards of IMDB's Top 250 Movies or Top 250 TV Shows.

**_Scenario_**: A person can view top 250 movies in a form of a card with its poster, Title and IMDB Rating.

**_Dependencies_**: IMDB Movie Dataset is available and accessible.

**_Assumptions_**: Ratings are out of 10.0


**_Scenario_**: A person can view top 250 TV Shows in a form of a card with its poster, Title and IMDB Rating.

**_Dependencies_**: IMDB TV Show Dataset is available and accessible.

**_Assumptions_**: Ratings are out of 10.0


**_Scenario_**: A person can search title from top 250 movies and TV shows.

**_Dependencies_**: IMDB Movie and TV Show Dataset is available and accessible.

**_Assumptions_**: Ratings are out of 10.0


**Example 1.1**
Given: Data of Top 250 Movies and TV Shows is available

When Search for "Fight Club"

Then Should receive one result tile with these attributes
1.	Fight Club
2.	Poster image
3.	IMDB Rating: 8.8

When clicked on Title, more details are displayed: 
1. Name: Fight Club (1999)
2. Movie Poster
3. Rank: 11
4. Cast: David Fincher (dir.), Brad Pitt, Edward Norton
5. IMDB Rating: 8.8
6. IMDB Count: 1965370


**Example 1.2**
Given: Data of Top 250 Movies and TV Shows is available

When Search for "Chernobyl"

Then Should receive one result tile with these attributes
1.	Chernobyl
2.	Poster image 
3.	IMDB Rating : 9.3

When clicked on Title, more details are displayed: 
1. Name: Chernobyl (2019)
2. Movie Poster
3. Rank: 5
4. Cast :Jessie Buckley, Jared Harris
5. IMDB Rating: 9.3
6. IMDB Count: 629209


**_Scenario_**: A person can view Top 15 Property listings in Chicago by clicking on Advertised image or navigation bar.

**_Dependencies_**: Chicago Property listing Dataset is available and accessible.

**_Assumptions_**: Listed properties are in Chicago.


**_Scenario_**: A person can view Top 15 Breweries by clicking on Advertised image or navigation bar.

**_Dependencies_**: Breweries Dataset is available and accessible.

**_Assumptions_**: Listed breweries are fully operational.

________________________________________
**SCRUM Roles**

-Product Owner/ Scrum Master: Sukanya Wadawadagi

-DevOps/ Frontend Developer: Vaishnavi Dubal and Anukriti Sharma

-Integration Developer: Anukriti Sharma and Sukanya Wadawadagi
________________________________________
**Weekly Meetings**

Tuesday at 6 pm in-person (during Lecture)

Friday at 1 pm on Teams

