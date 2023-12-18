# BDD Workshop demo files

## Disclaimer

The source code shown in this repository is intended to support the historical evolution of testing techniques on a workshop around TDD/ATDD/BDD called:

***Behavior Oriented Development as Test Automation Mechanism***

This code is not:

* Suitable for production
* It's intentionally simple to ensure non .net coders will understand the basics. The architecture is highly coupled to reduce complexity
* The Front-End is not beauty.
* Was not created to support a CI/CD pipeline. Just to show the techniques around TDD/ATDD/BDD

In few words: You'll find it plenty of potential improvements. **Feel free to fork and discuss.**

## The Repository

The way to use these code examples is by progressing through the steps, starting from step 1. That will provide a historical evolution on the tester roles, from the ad-hoc testing to the more modern automated tests resulted from Behaviour-driven Methodologies

The way to use it is fairly simple:

- Clone the repository

```console
~$ git clone https://github.com/naadev/bdd.workshop.git 
~$ gcd bdd.workshop 
```

- Checkout step-1 to begin the workshop

```console
~$ git checkout step-1
```
As you progress through the workshop you can checkout the code being reviewed. In example:


```console
~$ git checkout step-9-atdd-mvp
```

The convention of branch names are step-**step number**-**optional_description**

A difference is on step-X. since step X is intended to show TDD, there are associated sub-steps to go in detail with following convention: 

step-X-TDD-sub-step-**sub step number**-**optional_description**

In example:
- **step-X-TDD-sub-step-0-create-failing-test** is followed by **step-X-TDD-sub-step-1-Number0-OK**

## Build

The repository is intended to be used for source code examination purposes only. If you want to reproduce tests showed in the workshop you'll need to build the solution.

You will also need to modify URL embedded in code for functional tests to point to wherever you deploy the solution.
