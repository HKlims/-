# Scenario Phone Bot

This example demonstrates a simple scenario-based phone bot built in ASP.NET Core.
It handles incoming calls via Twilio webhooks and responds according to detected keywords.

## Prerequisites

- .NET 7 SDK
- A Twilio account and phone number

## Running

1. Install dependencies:
   ```bash
   dotnet restore
   ```
2. Build and run the application:
   ```bash
   dotnet run --project ScenarioPhoneBot
   ```
3. Expose the application to the internet (e.g., using `ngrok`) and configure your Twilio phone number's voice webhook to `https://<your-domain>/voice`.

Incoming speech will be routed to the `ScenarioManager` for a reply and spoken back to the caller.
