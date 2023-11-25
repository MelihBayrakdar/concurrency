# Week 1:

Main objectives of this week is to introduce the main concepts and prepare practical tools needed for upcoming weeks.

## Preparation:

1.  We will discuss about threads in week 3. Here, just think about a thread as a separate paths of execution that can be executed simultaneously with the main program.
2.  Refresh your C# programming environment: You are expected to be able to write simple console based programs. A set of possible concepts to be used later are: fundamentals (types, conditional statements, loops), defining attributes, methods, public / private / static, arrays, anonymous functions.
3.  Implement a simple program: like a counter class that counts until a given number and the main program instantiates an object from this class and prints the final result. The counter class has a state that keeps the latest counting value.

## Exercises:

_note: just for today ignore the **#todo** inside the code that ask you to write code, we will focus on the understanding and not on producing code._

1. [~ 5 min ] Concurrency in your machine:
   1. Make a list of parallel/concurrent programs in your computer. Choose a running program (for example PyCharm) and see how many threads are running by the application. You can check threads' count in your _task manager/activity monitor_ (on Windows _task manager click_ on the columns name to select columns and add threads if it is not already visible). You can also use in the Linux/MAC shell the command **"top"** (#TH --> total threads/running threads).
   2. Open an internet browser with several tabs (_Chrome_) of the same domain website. Check how many threads are created per process (the threads are not directly named but they are listed as parts of the single process: they all have the same Process ID, but contains multiple lines). Make a list (at least five) of _functionalities_ (tasks) that each thread of execution is responsible to execute.
   3. Share your list with the teacher.
2. [~ 30 min ] **MergeSort**: One of the challenges in designing a concurrent program is to recognise potential concurrent tasks.
   In Week 1, ignore the class named **ConcurrentMergeSort** and its todos.

   1. Among various sort algorithms one of the well-known ones is named **merge sort** algorithm. Read and understand how this algorithm works. You can use the following resources: [check here](https://www.hackerearth.com/practice/algorithms/sorting/merge-sort/visualize/) , or [here, just don't forget to choose right settings](https://visualgo.net/bn/sorting?slide=1).
   2. **Note**: In week three you will be asked to implement a concurrent version of this algorithm. Therefore, this exercise is crucial to understand and share your ideas.

      1. If you checked the visual algorithm displayed from the above links you should have noted that changes the order and rebuild the re-organised data, can you find these 2 methods in the code?
      2. How can we make it run faster if we had multiple processors available?
      3. Can you recognise sorting tasks that can be done _simultaneously_?

   3. Share your answers with the teacher.

# Melih Bayrakdar Week 1

1.  1.  I chose Visual Studio Code (VSC) as the program. During the time VSC had [36 threads](vscThreads.png) running.
    2.  I opened several youtube.com tabs and the amount of threads grew every time I opened a new tab. Strangely enough, after a while the amount of threads kept lowering while having the same tabs open. [These threads](safariThreads.png) belong to Safari, where Brightspace, Github, and 6 Youtube tabs are open.
        The list:
        1.  Thread 79264: This thread is named 'JavaScriptCore libpas scavenger', which works as a scavenger.
        2.  Thread 4926: The name contains 'private'. I'm guessing this thread holds control over the private way of browsing (incognito mode).
        3.  Thread 4726: This thread is called 'NSEventThread'.
        4.  Thread 3980: This thread contains 'coreanimation' and then 'render-server'. I don't have any knowledge on this type of threads, but I suppose they're rendering something.
        5.  Thread 79266: This thread is somewhat empty. It has been made when I opened a new tab of Youtube. There is a great chance this thread is now non-existent (see 2.).
    3.  Not done yet.
