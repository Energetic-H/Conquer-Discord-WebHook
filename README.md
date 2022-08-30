# Conquer-Discord-WebHook
Simple C# written code to send messages embeds and files using discord webhooks.
<p> We  are using the .NET Framework. </p>
<h1 dir="auto"><a id="user-content-login-register" class="anchor" aria-hidden="true" href="#login-register"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Setting Up</h1>
<p>1-Go to visual studio</p>
<p>2-Press on Tools</p>
<p>3-Chose NuGet Packages</p>
<p>4-Search for: System.Net.Http;</p>
 
<blockquote>
<p dir="auto">Code Example In World Chat</p>
</blockquote>
<p>Don`t forget take copy from folder 64 from data/playerface and set it in your site files</p>
<p>
<pre>
Discord.DiscordSendMessage(msg._From, msg.__Message, $"GameLink/64/{client.Player.Face}.jpg");
</pre>
