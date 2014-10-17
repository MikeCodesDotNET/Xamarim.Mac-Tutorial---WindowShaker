Xamarin.Mac Window Shaker
==========

##An extension method for NSWindow to shake it

![screenshot](http://i0.wp.com/micjames.co.uk/wp-content/uploads/2014/01/Screen-Shot-2014-01-08-at-12.06.52.jpg)

If your app has a login view or requires user credentials then this extension method will be very useful to you. When you detect an error with the credentials provided, simply call the following: 

```
this.Window.Shake();
```

The window will then shake 3 times (as per the default OS X login view). 