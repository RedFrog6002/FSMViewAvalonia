## Contributing to c# conversion

This is dedicated to documentation on how to contribute to c# conversion for this project.
C# conversion is exactly what it sounds like: It's converting playmaker fsms into c# classes.
This can be very useful, and can be used to outright replace fsms in games so you don't need to mess with editing them at runtime.

### Background

Before we start, there's a couple things we should get out of the way:
  - When I mention runtime I'm referring to when the generated c# code is run, not this program. When referring to fsms being converted, I'll use buildtime.
  - Fsms are made up of states, which are made up of actions and transitions. There are many types of actions, each with their own function. You can view the code for these in dnspy or ilspy.
    - If the actions already have code then why can't we just automatically convert that and not go through with converting all 1000+ actions?
      - We could do that, but there'd be a **lot** of logic needed to be put in place. For example, since we aren't using Fsm types such as FsmInt in outputted classes, any checking for if the value "IsNone" needs to be at buildtime, more on this in **Simplification**.
  - WIP

### Writing conversion for an action type

WIP

### FsmStateBuilder class

WIP

### ActionCode class

WIP

### Simplification

WIP

### Transitions

WIP
