




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class MathLogicMod : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #1
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: (r.expr(10) % 3) */
                 var obtained = runOrCatch( r.expr(10L).mod(3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #1
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: (10 % r.expr(3)) */
                 var obtained = runOrCatch( r.mod(10L, r.expr(3L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #1
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: (r.expr(10).mod(3)) */
                 var obtained = runOrCatch( r.expr(10L).mod(3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #2
                 /* ExpectedOriginal: -1 */
                 var expected_ = -1L;
                 
                 /* Original: r.expr(-10) % -3 */
                 var obtained = runOrCatch( r.expr(-10L).mod(-3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #3
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(1L));
                 
                 /* Original: r.expr(4) % 'a' */
                 var obtained = runOrCatch( r.expr(4L).mod("a") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #4
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('a') % 1 */
                 var obtained = runOrCatch( r.expr("a").mod(1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/mod.yaml, #5
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type NUMBER but found STRING.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(0L));
                 
                 /* Original: r.expr('a') % 'b' */
                 var obtained = runOrCatch( r.expr("a").mod("b") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}