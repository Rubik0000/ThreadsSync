#Provider - Consumer
OS lab1 № 2 1 8

A Provider generates a data and sends it to a buffer. 
The buffer size is limited. A consumer takes the data from the buffer.
The provider can't push the data if the buffer is full.
The consumer can't take the data if the buffer is empty.
The provider and the consumer can't use the buffer at the same time.

##The task
1. A buffer representation - a queue
2. A synchronization - a critical section (lock)

It needs to create a multithreaded application with one thread - a writer that pushes a data into a buffer.
The main thread creates readers that remove the data from the buffer. Each reader's thread finishes after reading.

##Getting started
Run the "SyncLock.exe" in "SyncLock/bin/Release/"

##Authors
**Oleg T**

