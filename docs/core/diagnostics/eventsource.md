---
title: EventSource Overview
description: Learn about EventSource in .NET and how to use it for tracing your .NET applications.
ms.date: 11/09/2020
ms.topic: overview
---

# EventSource

<xref:System.Diagnostics.Tracing.EventSource?displayProperty=nameWithType> is .NET Standard compatible API that allows you to log serializable objects from your application. Logs written using EventSource can be consumed in-process using <xref:System.Diagnostics.Tracing.EventListener?displayProperty=nameWithType>, or out-of-process using [ETW](/windows/win32/etw/event-tracing-portal), [LTTng](./trace-perfcollect-lttng.md), or [EventPipe](./eventpipe.md).

This documentation explains the overall concept of EventSource, how to write your own EventSource for tracing and logging, how to consume events written, as well as several guidances on how to write performant EventSources.

## Writing your own EventSource


## Consuming events written from your EventSource


## Caveats


## Best Practices


## 


## 

