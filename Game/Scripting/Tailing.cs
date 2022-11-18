// using System;
// using System.Collections.Generic;
// using System.Data;
// using Unit05.Game.Casting;
// using Unit05.Game.Services;


// namespace Unit05.Game.Scripting
// {
//     public class Trailing : Action
//     {
//         Snake snake = new Snake();
//         Score score = new Snake();
//         Food food = new Food();
//          /// <inheritdoc/>
//         public void Execute(Cast cast, Script script)
//         {
//             int points = food.GetPoints();
//             snake.GrowTail(points);
//         }
//     }
// }