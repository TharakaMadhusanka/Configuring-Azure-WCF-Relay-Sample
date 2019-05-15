# Configuring-Azure-WCF-Relay-Sample

This is a sample application, which uses Azure WCF relay service to communicate with WCF Service hosted in IIS.

Before you use this project, you have to replace the followings with your Azure WCF Relay.

- WCFClient Project => ValuesController.cs | [Your Relay Url], [Your Relay Policy Key] and [ Your Policy Key Value]
- WCFService1 Project => Web.config | [Your Relay Connection String], [Your Relay Policy Key] and [Your Relay Policy Key]
