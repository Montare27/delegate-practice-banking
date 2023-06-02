# Usage delegates and events at Banking App

<i>Simple study project with easy business logic</i> <p>
The business logic of application is as easy as possible and consists in the fact that class <code>AccountHandler</code> contains delegate <code>AccountDelegate</code>, to which all instances of class <code>Account</code> are connected by event. <p> The events themselves store the information about balance changes. You can also attach to <code>AccountHandler</code> class delegate any method which can be inherited from <code>IMessageAction</code> interface and you can select what to do with the obtained information.  For example: output to console, to logs, output to file.

<p>
Here I used Onion-architecture and Repository pattern.
<p>As a client here I prefer CLI.

