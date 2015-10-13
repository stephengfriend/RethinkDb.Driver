




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
    public class Range : GeneratedTest {



        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #1
                 /* ExpectedOriginal: STREAM */
                 var expected_ = "STREAM";
                 
                 /* Original: r.range().type_of() */
                 var obtained = runOrCatch( r.range().typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #2
                 /* ExpectedOriginal: [0, 1, 2, 3] */
                 var expected_ = r.array(0L, 1L, 2L, 3L);
                 
                 /* Original: r.range().limit(4) */
                 var obtained = runOrCatch( r.range().limit(4L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #3
                 /* ExpectedOriginal: [0, 1, 2, 3] */
                 var expected_ = r.array(0L, 1L, 2L, 3L);
                 
                 /* Original: r.range(4) */
                 var obtained = runOrCatch( r.range(4L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #4
                 /* ExpectedOriginal: [2, 3, 4] */
                 var expected_ = r.array(2L, 3L, 4L);
                 
                 /* Original: r.range(2, 5) */
                 var obtained = runOrCatch( r.range(2L, 5L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #5
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.range(0) */
                 var obtained = runOrCatch( r.range(0L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #6
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.range(5, 2) */
                 var obtained = runOrCatch( r.range(5L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #7
                 /* ExpectedOriginal: [-5, -4, -3] */
                 var expected_ = r.array(-5L, -4L, -3L);
                 
                 /* Original: r.range(-5, -2) */
                 var obtained = runOrCatch( r.range(-5L, -2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #8
                 /* ExpectedOriginal: [-5, -4, -3, -2, -1, 0, 1] */
                 var expected_ = r.array(-5L, -4L, -3L, -2L, -1L, 0L, 1L);
                 
                 /* Original: r.range(-5, 2) */
                 var obtained = runOrCatch( r.range(-5L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #10
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array());
                 
                 /* Original: r.range("foo") */
                 var obtained = runOrCatch( r.range("foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #11
                 /* ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer \\(>2\\^53\\). 9007199254740994", []) */
                 var expected_ = err_regex("ReqlQueryLogicError", "Number not an integer \\(>2\\^53\\). 9007199254740994", r.array());
                 
                 /* Original: r.range(9007199254740994) */
                 var obtained = runOrCatch( r.range(9007199254740994L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #12
                 /* ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer \\(<-2\\^53\\). -9007199254740994", []) */
                 var expected_ = err_regex("ReqlQueryLogicError", "Number not an integer \\(<-2\\^53\\). -9007199254740994", r.array());
                 
                 /* Original: r.range(-9007199254740994) */
                 var obtained = runOrCatch( r.range(-9007199254740994L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #13
                 /* ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer. 0\\.5", []) */
                 var expected_ = err_regex("ReqlQueryLogicError", "Number not an integer. 0\\.5", r.array());
                 
                 /* Original: r.range(0.5) */
                 var obtained = runOrCatch( r.range(0.5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #14
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().count() */
                 var obtained = runOrCatch( r.range().count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #15
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().coerce_to("ARRAY") */
                 var obtained = runOrCatch( r.range().coerceTo("ARRAY") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #16
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().coerce_to("OBJECT") */
                 var obtained = runOrCatch( r.range().coerceTo("OBJECT") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, range.yaml, #17
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: r.range(4).count() */
                 var obtained = runOrCatch( r.range(4L).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}