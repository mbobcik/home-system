# Home System

This repo (will) contain sourcecode for custom made home assistance system I had in mind for quite a while.
Main purpose of it is to notify home dwellers about various situations such as end of washing machine programme, or rain closing in on drying laundry.

## Notifications
Notification can be added manualy or automatically.
For example someone fills washing machine and start the programme, then sets up notification request via IoT terminal.
User can select duration of the programme or set exact time for notification to fire.
When its time, system will hit the buzzer in more frequent room of the house and some sort of display will show what's up.
Notification results (in this example buzzer and display) could be moddable to also run some code, ping some API or use other custom made module.

### Automatic notifications
Automatic notification source have two subtypes. Scheduled and discovered.
Scheduled have the same behaviour as scheduled meetings in other calendar apps or as cron jobs.
Discovered notifications are a bit more complicated.
Imagine you have your precious laundry drying out on the garden and as you start doing something else you forget about it, or you don't notice it started to rain.
Home system here to help by periodically checking weather forecast or smoke status and alerting you.
This could be  combined to only fire when some other notification is active (only when you have loundry out).

### Premade notifications
To decrease human interaction with the system needed to set up notification system can contain premade notifications. 
Just select washing machine notification and the system knows average duration and what to do when time's up.

# scheduler
    
* API to call from portal, terminal and discoverer
 
# Jobmaster

* periodically check database for events, and process them when it is time
* send commands to various terminals specified in event tasks

# DB