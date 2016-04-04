FsStorm [![Windows build](https://ci.appveyor.com/api/projects/status/5tyo7yitpiqswooq?svg=true)](https://ci.appveyor.com/project/et1975/fsstorm-y1wvk) [![Mono/OSX build](https://travis-ci.org/FsStorm/FsStorm.svg?branch=master)](https://travis-ci.org/FsStorm/FsStorm)
=======

A project for defining and running Apache Storm topologies in F#

See [this blog post][fwaris blog post] for an intro and [docs][docs] for an overview.

Join the conversation: [![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/FsStorm/FsStorm?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

> Update: 
> Insights gained from working with FsStorm have led to a spinoff: [FsShelter](https://github.com/prolucid/FsShelter), check it out if you like the idea of statically typed topologies. 

# Building
```
build
```

# Running the tests
Building from command line runs the unit tests.
IDE: Install NUnit plugin for VS or MonoDevelop to see the unit-tests in Test Explorer and step through the code under debugger.

# Submitting the topology
Have a local [Storm](https://storm.apache.org/downloads.html) installed and running.
Make sure F# interpreter is in the path and from the repository root run:
```
fsi src\FstSample\Submit.fsx
```
or, if running on Mono:
```
fsharpi src/FstSample/Submit.fsx
```

# Seeing the topology in action
Open [Storm UI](http://localhost:8080/) and see the Storm worker logs for runtime details.

[fwaris blog post]:https://fwaris.wordpress.com/2015/01/21/stormin-f/
[docs]:http://fsstorm.github.io/FsStorm/
