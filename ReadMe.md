# JJB Notes

We'll be checking out something called LiveXAML for Xamarin Forms.
-- There are lots of limitations to Xamarin Live Player. LiveXAML is a competitor.
-- LiveXAML is running your app, not hosting it in a separate app like Live Player.
-- Allows you to change xaml and see updates on the fly.

Realm Mobile DB
== Relational database for mobile.
== Free & OS
== Works to sync your mobile db with the realm object server.

Iconize library
== Don't worry about including image assets or the image asset sizes.
== Extensible with things like FontAwesome.




# Beer Drinking

Data is relational, and the database in your Mobile App should be too. The Beer Drinking app demonstrates using the Realm Mobile Database for relating Breweries with the Beers they brew.

### Prerequisites

Make sure you have checked out the general [Meetup Prerequisites](https://github.com/SDXamarinDevs/Meetups)

## Level 0

- Register the views with the Container
- Update the Navigation Commands
- Pass the necessary object from page to page
- Run the app

### Notes

When Navigating to a Brewery you will use the DynamicTabbedPage with tabs for the BreweryDetailPage and the BreweryBeersPage
The Realm registration must be Transient, and will require Setup to allow a Disposable Transient
When Navigating to the BeerPage from the BreweryBeers page be sure to specify `useModalNavigation: false`. This will ensure that you are able to use the NavigationPage's built in Navigation Bar to go back to the TabbedPage

## Level 1

- Add a menu option to add a new Brewery
- Add a simple form to add the Brewery

### Notes

You are able to bind directly to properties of a Model. You can look at the included View's for an example of how to do this. To make it easier create a new instance of the Brewer model and bind to it's properties. Then on save you can add it to the Realm.

## Level 2

- Add a menu option to add a beer
- Add a basic view to add a new beer

## Boss Level

- Create a Realm Object Server on Amazon EC2, Azure, or Digital Ocean
- Update the RealmConfiguration in the AppConstants to provide a SyncConfiguration
- Connect your mobile app to the Realm Object Server
- Watch as you make a change on one device and it pops up on another device.

### Notes

Be sure to comment out the Seed method in the Splash Screen
After your Realm Object Server is deployed write down the IP address of the server and navigate to {ip address}:9080
The first time you go to the Dashboard you will be prompted to create an Admin account
Update your Realm Configuration to use a SyncConfiguration. You can update the Secrets.json with the IP for the Realm Object Server.

TIPS:
= Split the work up.
= Consider mobbing.