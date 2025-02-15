# Week 2:

The main objectives are to understand and apply concepts of processes and inter-process communications in programming. In this week you will learn:
- how to obtain processes information from os.
- how to create and run a process through a program.
- how can two running processes communicate with each other.

## Preparation:
1. Use the online reference below and answer the questions:
Reference: [Process handling in C#](https://www.dotnetperls.com/process)
- Which namespace is needed?
- Which class and method are used to run a process?
- How can we modify properties of a process?
- How can we get a list of currently running processes?
2. Use the online reference below to find more information about **Process** component.
Reference: [System calls to make processes](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.process?view=net-6.0)

## Exercises:

1. [~ 20 min ] **Processes**: The program will give a list of currently running processes. Names and Ids are printed. 
	1. Compare Ids and Names with your machine activity (task) manager program. Choose a process id from your computer that its termination is safe: like whatsapp, editors, browser. Check if the program terminates the given process completely.
	2. **[@home]** Add a method to the program that gets the name of a process and prints the related id.
2. [~ 20 min ] **[Solution will be Available]** **ProcessCreation**: Implement a program, that executes a command, like **ls**/**dir**.
After that, modify your program such that executes the **Processes** (try to run the previous exercise-compiled-version of the dll/exe, and check the references, it should be in the bin directory of **Processes** ).

3. [~ 30 min ] **[Solution will be Available]** **IPCNamedClient, IPCNamedServer**: Two projects are implemented to present how two programs can communicate using named pipes.
**Note**: Client and server naming is not following strict definition of client-server roles, it is just oriented to have a peer to peer communication.
	1. Read and analyse the programs for both client and server. What do you expect from the behaviour of these programs?
	2. Run the server, run the client. Check the behaviour.
	3. Run one server and two clients. Does the server communicate with both clients?
	4. What will happen if the name of the pipe in the server is different from the client? Change the name of the pipe in the server (or the client). Re-run both the client and server. Can they communicate? 
	5. Named pipes are meant for programs where two-way communication is needed. The current implementation provides only one-way communication (from the server to the client). Extend the programs such that the client sends the result of its processing (i.e. reversed message) back to the server. The server will print the result received from the client.
<!-- Solution: Is available. -->

4.  [~ 20 min ] **[@home]** Using named pipes implement a client / server program where the client sends the *name and the path* of an executable program to the server and the server starts the process given by the client.

<!-- (Optional) Read this tutorial and practice an example about AnonymousPipes: https://ingeno.io/2016/09/c-anonymous-pipes-for-interprocess-communication/  -->


# Melih Bayrakdar Week 2

# Preparation
1.  .
    -	System.Diagnotics is being used for the processes. At some point System.Threading and System.IO is also being used.
    -	The Process class is being used with the methods Start().
	-	With the class ProcessStartInfo we can modify parts of the process properties.
	-	There is a method called GetProcesses() in the Process class. Calling this method will get you returned an array.

# Exercises
1.	Concurrency > Folder: Processes
	1.	[This code snippet](processterminate.png) handles the termination of a process by giving the Process Id. It indeed terminates the chosen process.
	2.	[This code snippet](processprintid.png) prints the process id by taking the name.

2. 	[This code snippet](processcreation.png) creates a new process and opens an executable file.
	I cannot run the Processes.dll file with the ProcessStartInfo object. Directly running the dll file via the terminal by typing 'dotnet /Users/melihbayrakdar/Documents/GitHub/concurrency/Processes/bin/Debug/net6.0/Processes.dll', it runs and apparently running the dll file just makes the Program.cs run. I will ask the teacher about running the Processes.dll file through the object.
	After asking the teacher, he pointed out that macOS users have the executable file without the .dll extension. 
	The Arguments property is changed to prInfo.Arguments = "../Processes/bin/Debug/net6.0/Processes"; The code works and by running the code it brings me to the running file of ProcessCreation.

3.	concurrency > Folder: IPCNamedClient & IPCNamedServer
	1. 	You basically type something in the server client and the other client will take the message and print it out in reverse order.
	2. 	Server output after running: 	"Pipe Server is being executed ...
										[Server] Enter a message to be reversed by the client (press ENTER to exit)"
		Client output after running: 	"Pipe Client is being executed ...
										[Client] waiting to receive a message"
	3.	No, it only interacts with one client, the one you start at first will be interacted with. The second client does not interact with the server.
	4. 	Changing the name of the pipe will not result in communication between the server and the client. 
	5.	[Client code](client.png) and [server code](server.png). Added reader and writer to both codes. I saved the reversed message in a variable and flushed it afterwards. Then I read the input and print the received variable.

4. See the following code: [Client code](pathclient.png) and [server code](pathserver.png).

