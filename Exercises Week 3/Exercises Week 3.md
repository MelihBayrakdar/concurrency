# Week 3:

The main objectives are to understand and apply concepts of multithreading. This week we will focus on disjoint threads, i.e. threads that do not communicate with each other. In this week you will learn:

- how to create and start a thread.
- how to join to a running thread.
- how to separate a task from a given sequential program to be running concurrently.

## Preparation:

1. Use the online refernce provided here and answer the following questions:
   Reference: [Multi-threading in C#](http://www.albahari.com/threading/) (Read only *Introduction and Concepts* from Part 1).
   1. What namespaces are needed to use threads?
   2. How can you create a thread?
   3. How do you specify a task to be executed by a thread?
   4. How should you start a thread?
   5. What is a main thread? 
   6. What does happen when a main thread starts another thread? 
   7. How can a main thread (or in general any thread) join another thread?
   8. What may happen if a main thread terminates and does not wait for another thread to join?

## Exercises:

1. [~ 5 min] In Week 1, it is discussed how a statement like **C=A+B** is translated to assembly instructions. Answer the following questions and share them with your teacher.
   1. Check the slides and write down the sequence of assembly code for **C=A+B**
   2. Assume two threads running concurrently. Thread 1 is executing **X=A+B** and thread 2 is executing **Y=C+D**. 
      1. Write down three **possible** interleavings (assembly instructions). 
      2. Write down three **impossible** interleavings.
2. [~ 30 min] **Threads**: A simple example about threads: creating, starting and joining threads.
   
   1. This example presents how to collect information about threads of a process.
   
      1. Follow todo #1 from class Examples. Run the code. 
      2. How information of threads are extracted? Which process is the owner of these threads? Check the code implemented in class ThreadsList.
   
   2. This example presents how to create and start multiple threads. Answer the questions below and justify your answers using the code.
   
      1. Follow todo #2 from class Examples. Run the code. In order to see the behaviour of the program you have to check todo #2.1 provided in method ThreadCreation::runExample().
      2. How can a main program create and start multiple threads? 
      3. How to define a task of a thread?
      4. How can a main program join to multiple threads?  
   
   3. This example presents a different scenario of defining tasks for the threads. 
   
      1. Follow todo #3 from class Examples. Run the code. Justify the behaviour of the program.
   
      2. Check details of the implementation in class ThreadsJoin. How is the task given to the threads? Compare it with class ThreadCreation. 
   
      3. What would be the behaviour of the program if we had the following scenario for joining (try and justify your answer):
         **t_A.Start();**
         **t_A.Join();**
         **t_B.Start();**
         **t_B.Join();**
   
3. [~ 30 min] **[Solution will be Available]** **PrimeNumbers**: A sample sequential code for finding prime numbers is given. Your task is to write a method that implements the concurrent version of this algorithm.
   
   1. Understand how the sequential version works. Run the code and check how much time does it take to finish the task. 
   2. Recognise which task can be divided between two (or more) threads.
   3. *Implementation*: Follow todo provided in the code to implement the exercise. For simplicity, implement **only for two threads**. 
   4. Check to see how the time for sequential version is implemented. Apply it to your concurrent solution. Run both sequential and concurrent versions. Is you concurrent version more efficient? 
4. [~ 30 min] **[Solution will be Available]** **[@home]**  **MergeSort**: A sample implementation of merge sort is given. It is implemented sequentially. Your task is to implement a multi-threaded MergeSort. *Note*: In order to practice with the concepts of merge sort, first, understand how the sequential version works. Check the exercises of Week 1. You can use online resources to observe its execution visually. 
   
   1. Recognise which task can be assigned to threads to be executed independently. For simplicity, assume only two threads.
   2. *Implementation*: Follow todos provided in the code to implement the exercise.


# Exercises

1.  .
    1.  The steps:
        1: define variable int A = 100
        2: define variable int B = 150
        3: define variable int C
        4: move to variable A value to register A
        5: add variable B value to register A
        6: move register A value to variable C
    2.  .
      1. Thread 1: LOAD A, Thread 1: LOAD B, Thread 1: ADD, Thread 2: LOAD C, Thread 2: LOAD D, Thread 2: ADD
         Thread 1: LOAD A, Thread 2: LOAD C, Thread 1: LOAD B, Thread 2: LOAD D, Thread 1: ADD, Thread 2: ADD
         Thread 2: LOAD C, Thread 1: LOAD A, Thread 2: LOAD D, Thread 1: LOAD B, Thread 1: ADD, Thread 2: ADD
      2. Thread 1: LOAD A, Thread 2: LOAD C, Thread 1: ADD, Thread 2: LOAD D, Thread 2: ADD, Thread 1: LOAD B
         Thread 1: LOAD A, Thread 2: LOAD C, Thread 2: LOAD D, Thread 1: ADD, Thread 2: ADD, Thread 1: LOAD B
         Thread 2: LOAD C, Thread 1: LOAD A, Thread 2: LOAD D, Thread 1: ADD, Thread 1: LOAD B, Thread 2: ADD

2. .
	1. .
		1. Runned the code.
      2. By going into process.Threads, you can extract the threads of a process. In this case it's the 'proc' variable's Threads object. 
   2. .
      1. Runned the code. 
      2. By running the Examples class and then running runExample().
      3. After creating a Thread object, you can specify its task within the parameters.
         Example: Thread tOne = new Thread(() => { for (int i = 0; i < 10000; i++) Console.Write("X"); });
         Or: Thread tOne = new Thread(printCounts);
      4. By calling `this.createMultipleThreads();` in `runExample()`.
   3. .
      1. Runned the code. 2 threads are being created by calling the countUntil() method. 
      2. Both ways include a method to decide the task of the threads. The threads of ThreadsJoin use the Join method to join the threads to the main thread. The ThreadCreation doesn't do that.
      3. The first thread is finishing first with his task. The second thread will then start doing his tasks. So A1 until A10 is being printed first, then B1 until B10.

3. .
   1. The sequential version takes approximately 11476 miliseconds.
   2. I think just dividing the maximum by 2 and giving the two portions to each thread.
   3. Done.
   4. It is more efficient. The concurrent version only took 6008 miliseconds.

4. .
   1. 