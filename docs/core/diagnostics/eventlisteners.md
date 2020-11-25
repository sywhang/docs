---
title: EventListeners in .NET
description: In this article, you'll learn what EventListeners are and how to use them for consuming events in-process.
ms.date: 11/24/2020
---

**This article applies to: ✔️** .NET Core 2.1 SDK and later versions, .NET Framework 4.5 and later versions.

# EventListeners in .NET

EventListeners in .NET are managed APIs that can be used for consuming events emitted by the runtime as well as custom events written with [EventSource](xref:System.Diagnostics.Tracing.EventSource) in-process.

This article explains how to use them, and recommended practices.

## Use EventListener to consume runtime events

The .NET runtime components emit various events that can be used to understand the internal behavior of the runtime. These events can be consumed via EventListener.

## FAQ


