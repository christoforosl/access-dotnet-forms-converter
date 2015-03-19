# access-dotnet-forms-converter
Automatically exported from code.google.com/p/access-dotnet-forms-converter
= Using The Access To .Net Forms Converter =

Steps to convert an Access Project (ADP) or database (MDB)

 # Download AccessDotNetConverter zip file, unzip it in a folder, OR checkout project and open it in .net 2010 and Compile it.
 # Make A backup Copy of the MDB/ADP of the MS Access database you want to convert.
 # Run the AccessDotNetConverter.exe.  The first time you run the executable, you will be in "New Project" mode.  

== Creating a New Project ==

A "Conversion Project" consists of 3 items of information:

 # The location of the configuration file of the project.
 # The root path to the .Net project that will receive converted forms
 # The source MS Access database 

After you select these 3 values, you can save the project, from the "File"->"Save Project" menu (Ctrl+S).

This will create the [ConfigurationFile Configuration File] of the project.  You can edit the Configuration File as per instructions [ConfigurationFile here]


== The Project Window==
https://msaccess-subversion-control.googlecode.com/svn/wiki/ConverterUI.png

 # The location of the configuration file of the project.  Click the "..." next to the field to select and load another project.
 # The root path to the .Net project that will receive converted forms.  Click the "..." next to the field to select another path.
 # The Source MS Access database. Click the "..." next to the field to select and load another MS Access database.
 # List of form names in the Source MS Access database. 
 # Button to convert selected forms
 # System Log

== Running from the command line ==
Syntax of Command line:

 # <code>AccessDotNetConverter -form [formname] -configFile [configfile]</code> Loads the config file specified in "configFile" parameter, and converts form name specified in parameter - form.
 # <code>AccessDotNetConverter -form [formname] -sourceAccessDatabase [path to ms access database]</code> Converts form name specified in parameter "form" from the access database specified in the "sourceAccessDatabase" parameter. The configuration file used is the [https://code.google.com/p/msaccess-subversion-control/source/browse/AccessSVNTool/trunk/AccessDotNetConverter/AccessToDotNetControlMap.xml default configuration file] of the application
