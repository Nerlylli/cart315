#### Sept. 21st, 2026 
==**22.29**==
	I kind of procrastinated during the weekend, so I am now starting the PONG tutorial, so I can add my variations. While following the tutorial in class, I had some ideas of modifications to make to the base game. I wanted to change the main goal, which is to stop the ball (with the paddle) from leaving the court. In my version, I wanted the goal to be to avoid the ball. Therefore, whenever the paddle of a player touches the ball, a point is lost; whenever the paddle of a player successfully avoids the ball, a point is gained. 
==**22.42**==
	The tutorial confuses me. The youtuber is using different terms and it's messing with my brain. I tried to skip through, because i had already done a lot in class, but I guess I won't be able to skip through as much as I want... *sad face emoji*
**==22.54==**
	I'm going to start all over again, because this is confusing the heck out of me. I feel like I'm back at square one, even though it seemed so easy and simple in class... *panic face emoji x3* 
**==23.57==**
	I was able to predict some code. I feel very smart and savvy-codey.
	
#### Sept. 22nd, 2026
**==00.08==**
	'InvalidOperationException : You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling into Input System Package in Player Settings.' Huh?
**==00.16==**
	* https://www.reddit.com/r/Unity3D/comments/1ixyuwk/how_do_i_fix_the_invalidoperationexception_you/
	THANK YOU RATYREL ON REDDIT!!
**==00.51==**
	Syntax errors will be the DEATH of me. 
**==01.10==**
	Syntax errors will be the DEATH of me. (part 2)
**==01.54==**
	I am finally done with the base of the game. 
	Later, I will add a few changes. 
	* Goal is to avoid the ball - make ball and paddle movement extremely fast
	* Change colors of the game
	++ more ideas to come
**==18.50==**
	I gave the paddles the scale.y of the ball, and I gave the ball the scale.y of the paddle
	I increase the ball's x scale, and decreased its y scale. The game is now harder to win, even though the AI version still manages to touch the "ball" successfully. 
**==18.54==**
	Increase the player's paddle's mass by .10, so that it can feel less light. Increased the linear damping by .5, so the paddle can actually stop when letting go of the 'W' or up key.
**==19.13==**
	Tried to add a rigidbody2d and bodycollider2d to the lines in the center of the game. At first, it was nice, because it allowed the ball to slow down and made it easier to touch it, but then it would be so slow that it just stopped moving. *sighs*
**==19.18==**
	I added multiple different balls, of all different sizes(x,y). They start at the same position(x,y), but move around the scene randomly. At first, there were some issues -- since there are so many balls, it is easy to miss some. As a result, the game would constantly restart, which was annoying. It didn't allow any gameplay. That's why I commented out all the lines that had '*ResetPosition*' & '*ResetRound* ' so that the game could continue. 