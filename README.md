DungeonResource
===============

Dungeons and Dragons references right at your fingertips.

What is this?
-------------

Dungeon Resource is a personal experiment with utilizing the latest and greatest technologies while providing useful tools to those happen to play Dungeons and Dragons v3.5

Can I See the Site in Action?
---------------------------------------

Of course! You can check out the site at http://dungeonresource.azurewebsites.net/

Can I Contribute?
------------------------

Of course! Feel free to create a fork, submit bug reports, request features, or just use the site.

Technologies Used
--------------------------

- ASP.NET MVC4
- WebAPI
- RenderJS
- Knockout
- RavenDB (Soon to be Switching to MongoDB)
- Twitter Bootstrap
- JQuery

Favorite Patterns and Practices
-------------------------------------------

- SOLID
- Service Layered Archetecture

How is the Code Structure?
--------------------------

The whole Dungeon Resource codebase is broken out to create the greatest amount of 
unit testibility and reusibility. While the whole structure does create a lot of 
overhead in terms of design, there is a huge improvement to developement when it 
comes to swapping out/changing integral components.

- DndDev.Domain

This project is reponsible for housing basic objects which can pass data between the 
project layers. The objects go my many names: Domain Objects, POCO objects, or DTO objects. 
For the scope of this project we will refer to it as Domain objects.

- DndDev.Repository

This project is responsible for managing all the external database access. Here is the 
only place where you will find actual calls out to a database. The reason why this is 
all in a separate project is to further expand the unit testibility and reusibility of 
the codebase.

- DndDev.Service

The project is responsible for handling all the business logic associated with the project.

- DndDev.MVC

This houses the actual website. Here you will find controllers, views, and webapi controllers 
which more or less serve out data provided by the service layer.


- DndDev.Scraper

This is a project that exists only for dirty database work. If I need to quickly convert 
certain datasources and add it into the database, this is the place to do it.


License
----------------------------

>Copyright (c) 2103 Grant Byrne
>
>Permission is hereby granted, free of charge, to any person obtaining a copy
>of this software and associated documentation files (the "Software"), to deal
>in the Software without restriction, including without limitation the rights
>to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
>copies of the Software, and to permit persons to whom the Software is
>furnished to do so, subject to the following conditions:
>
>The above copyright notice and this permission notice shall be included in
>all copies or substantial portions of the Software.
>
>THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
>IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
>FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
>AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
>LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
>OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
>THE SOFTWARE.


