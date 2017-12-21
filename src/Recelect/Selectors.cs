using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Recelect
{
    public static class Selectors
    {
        static Func<TInput, TOutput> Memoize<TInput, TOutput>(Func<TInput, TOutput> func)
        {
            var memo = new ConcurrentDictionary<TInput, TOutput>(EqualityComparer<TInput>.Default);
            TOutput Result(TInput selector)
            {
                if (memo.TryGetValue(selector, out var q))
                {
                    return q;
                }
                else
                {
                    var r = func(selector);
                    memo[selector] = r;
                    return r;
                }
            }
            return Result;
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1>(
            Func<TInput, T1> selector1,
            Func<T1, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(selector1(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<T1, T2, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<T1, T2, T3, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<T1, T2, T3, T4, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<T1, T2, T3, T4, T5, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<T1, T2, T3, T4, T5, T6, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<T1, T2, T3, T4, T5, T6, T7, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<TInput, T11> selector11,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(selector11, nameof(selector11));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state),
                    selector11(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<TInput, T11> selector11,
            Func<TInput, T12> selector12,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(selector11, nameof(selector11));
            ArgumentNotNull(selector12, nameof(selector12));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state),
                    selector11(state),
                    selector12(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<TInput, T11> selector11,
            Func<TInput, T12> selector12,
            Func<TInput, T13> selector13,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(selector11, nameof(selector11));
            ArgumentNotNull(selector12, nameof(selector12));
            ArgumentNotNull(selector13, nameof(selector13));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state),
                    selector11(state),
                    selector12(state),
                    selector13(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<TInput, T11> selector11,
            Func<TInput, T12> selector12,
            Func<TInput, T13> selector13,
            Func<TInput, T14> selector14,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(selector11, nameof(selector11));
            ArgumentNotNull(selector12, nameof(selector12));
            ArgumentNotNull(selector13, nameof(selector13));
            ArgumentNotNull(selector14, nameof(selector14));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state),
                    selector11(state),
                    selector12(state),
                    selector13(state),
                    selector14(state));
            });
        }

        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<TInput, T11> selector11,
            Func<TInput, T12> selector12,
            Func<TInput, T13> selector13,
            Func<TInput, T14> selector14,
            Func<TInput, T15> selector15,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(selector11, nameof(selector11));
            ArgumentNotNull(selector12, nameof(selector12));
            ArgumentNotNull(selector13, nameof(selector13));
            ArgumentNotNull(selector14, nameof(selector14));
            ArgumentNotNull(selector15, nameof(selector15));
            ArgumentNotNull(combine, nameof(combine));


            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state),
                    selector11(state),
                    selector12(state),
                    selector13(state),
                    selector14(state),
                    selector15(state));
            });
        }


        public static Func<TInput, TOutput> CreateSelector<TInput, TOutput, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Func<TInput, T1> selector1,
            Func<TInput, T2> selector2,
            Func<TInput, T3> selector3,
            Func<TInput, T4> selector4,
            Func<TInput, T5> selector5,
            Func<TInput, T6> selector6,
            Func<TInput, T7> selector7,
            Func<TInput, T8> selector8,
            Func<TInput, T9> selector9,
            Func<TInput, T10> selector10,
            Func<TInput, T11> selector11,
            Func<TInput, T12> selector12,
            Func<TInput, T13> selector13,
            Func<TInput, T14> selector14,
            Func<TInput, T15> selector15,
            Func<TInput, T16> selector16,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOutput> combine)
        {
            ArgumentNotNull(selector1, nameof(selector1));
            ArgumentNotNull(selector2, nameof(selector2));
            ArgumentNotNull(selector3, nameof(selector3));
            ArgumentNotNull(selector4, nameof(selector4));
            ArgumentNotNull(selector5, nameof(selector5));
            ArgumentNotNull(selector6, nameof(selector6));
            ArgumentNotNull(selector7, nameof(selector7));
            ArgumentNotNull(selector8, nameof(selector8));
            ArgumentNotNull(selector9, nameof(selector9));
            ArgumentNotNull(selector10, nameof(selector10));
            ArgumentNotNull(selector11, nameof(selector11));
            ArgumentNotNull(selector12, nameof(selector12));
            ArgumentNotNull(selector13, nameof(selector13));
            ArgumentNotNull(selector14, nameof(selector14));
            ArgumentNotNull(selector15, nameof(selector15));
            ArgumentNotNull(selector16, nameof(selector16));
            ArgumentNotNull(combine, nameof(combine));

            return Memoize<TInput, TOutput>(state =>
            {
                return combine(
                    selector1(state),
                    selector2(state),
                    selector3(state),
                    selector4(state),
                    selector5(state),
                    selector6(state),
                    selector7(state),
                    selector8(state),
                    selector9(state),
                    selector10(state),
                    selector11(state),
                    selector12(state),
                    selector13(state),
                    selector14(state),
                    selector15(state),
                    selector16(state));
            });
        }

        static void ArgumentNotNull<T>(T value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
