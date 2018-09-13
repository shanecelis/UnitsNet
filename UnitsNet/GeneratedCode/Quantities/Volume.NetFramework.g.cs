﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Volume is the quantity of three-dimensional space enclosed by some closed boundary, for example, the space that a substance (solid, liquid, gas, or plasma) or shape occupies or contains.[1] Volume is often quantified numerically using the SI derived unit, the cubic metre. The volume of a container is generally understood to be the capacity of the container, i. e. the amount of fluid (gas or liquid) that the container could hold, rather than the amount of space the container itself displaces.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Volume : IComparable, IComparable<Volume>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Volume from nullable AuTablespoons.
        /// </summary>
        public static Volume? FromAuTablespoons(QuantityValue? autablespoons)
        {
            return autablespoons.HasValue ? FromAuTablespoons(autablespoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Centiliters.
        /// </summary>
        public static Volume? FromCentiliters(QuantityValue? centiliters)
        {
            return centiliters.HasValue ? FromCentiliters(centiliters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicCentimeters.
        /// </summary>
        public static Volume? FromCubicCentimeters(QuantityValue? cubiccentimeters)
        {
            return cubiccentimeters.HasValue ? FromCubicCentimeters(cubiccentimeters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicDecimeters.
        /// </summary>
        public static Volume? FromCubicDecimeters(QuantityValue? cubicdecimeters)
        {
            return cubicdecimeters.HasValue ? FromCubicDecimeters(cubicdecimeters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicFeet.
        /// </summary>
        public static Volume? FromCubicFeet(QuantityValue? cubicfeet)
        {
            return cubicfeet.HasValue ? FromCubicFeet(cubicfeet.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicInches.
        /// </summary>
        public static Volume? FromCubicInches(QuantityValue? cubicinches)
        {
            return cubicinches.HasValue ? FromCubicInches(cubicinches.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicKilometers.
        /// </summary>
        public static Volume? FromCubicKilometers(QuantityValue? cubickilometers)
        {
            return cubickilometers.HasValue ? FromCubicKilometers(cubickilometers.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicMeters.
        /// </summary>
        public static Volume? FromCubicMeters(QuantityValue? cubicmeters)
        {
            return cubicmeters.HasValue ? FromCubicMeters(cubicmeters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicMicrometers.
        /// </summary>
        public static Volume? FromCubicMicrometers(QuantityValue? cubicmicrometers)
        {
            return cubicmicrometers.HasValue ? FromCubicMicrometers(cubicmicrometers.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicMiles.
        /// </summary>
        public static Volume? FromCubicMiles(QuantityValue? cubicmiles)
        {
            return cubicmiles.HasValue ? FromCubicMiles(cubicmiles.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicMillimeters.
        /// </summary>
        public static Volume? FromCubicMillimeters(QuantityValue? cubicmillimeters)
        {
            return cubicmillimeters.HasValue ? FromCubicMillimeters(cubicmillimeters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable CubicYards.
        /// </summary>
        public static Volume? FromCubicYards(QuantityValue? cubicyards)
        {
            return cubicyards.HasValue ? FromCubicYards(cubicyards.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Deciliters.
        /// </summary>
        public static Volume? FromDeciliters(QuantityValue? deciliters)
        {
            return deciliters.HasValue ? FromDeciliters(deciliters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable HectocubicFeet.
        /// </summary>
        public static Volume? FromHectocubicFeet(QuantityValue? hectocubicfeet)
        {
            return hectocubicfeet.HasValue ? FromHectocubicFeet(hectocubicfeet.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable HectocubicMeters.
        /// </summary>
        public static Volume? FromHectocubicMeters(QuantityValue? hectocubicmeters)
        {
            return hectocubicmeters.HasValue ? FromHectocubicMeters(hectocubicmeters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Hectoliters.
        /// </summary>
        public static Volume? FromHectoliters(QuantityValue? hectoliters)
        {
            return hectoliters.HasValue ? FromHectoliters(hectoliters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable ImperialBeerBarrels.
        /// </summary>
        public static Volume? FromImperialBeerBarrels(QuantityValue? imperialbeerbarrels)
        {
            return imperialbeerbarrels.HasValue ? FromImperialBeerBarrels(imperialbeerbarrels.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable ImperialGallons.
        /// </summary>
        public static Volume? FromImperialGallons(QuantityValue? imperialgallons)
        {
            return imperialgallons.HasValue ? FromImperialGallons(imperialgallons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable ImperialOunces.
        /// </summary>
        public static Volume? FromImperialOunces(QuantityValue? imperialounces)
        {
            return imperialounces.HasValue ? FromImperialOunces(imperialounces.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable KilocubicFeet.
        /// </summary>
        public static Volume? FromKilocubicFeet(QuantityValue? kilocubicfeet)
        {
            return kilocubicfeet.HasValue ? FromKilocubicFeet(kilocubicfeet.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable KilocubicMeters.
        /// </summary>
        public static Volume? FromKilocubicMeters(QuantityValue? kilocubicmeters)
        {
            return kilocubicmeters.HasValue ? FromKilocubicMeters(kilocubicmeters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable KiloimperialGallons.
        /// </summary>
        public static Volume? FromKiloimperialGallons(QuantityValue? kiloimperialgallons)
        {
            return kiloimperialgallons.HasValue ? FromKiloimperialGallons(kiloimperialgallons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable KilousGallons.
        /// </summary>
        public static Volume? FromKilousGallons(QuantityValue? kilousgallons)
        {
            return kilousgallons.HasValue ? FromKilousGallons(kilousgallons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Liters.
        /// </summary>
        public static Volume? FromLiters(QuantityValue? liters)
        {
            return liters.HasValue ? FromLiters(liters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable MegacubicFeet.
        /// </summary>
        public static Volume? FromMegacubicFeet(QuantityValue? megacubicfeet)
        {
            return megacubicfeet.HasValue ? FromMegacubicFeet(megacubicfeet.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable MegaimperialGallons.
        /// </summary>
        public static Volume? FromMegaimperialGallons(QuantityValue? megaimperialgallons)
        {
            return megaimperialgallons.HasValue ? FromMegaimperialGallons(megaimperialgallons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable MegausGallons.
        /// </summary>
        public static Volume? FromMegausGallons(QuantityValue? megausgallons)
        {
            return megausgallons.HasValue ? FromMegausGallons(megausgallons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable MetricCups.
        /// </summary>
        public static Volume? FromMetricCups(QuantityValue? metriccups)
        {
            return metriccups.HasValue ? FromMetricCups(metriccups.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable MetricTeaspoons.
        /// </summary>
        public static Volume? FromMetricTeaspoons(QuantityValue? metricteaspoons)
        {
            return metricteaspoons.HasValue ? FromMetricTeaspoons(metricteaspoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Microliters.
        /// </summary>
        public static Volume? FromMicroliters(QuantityValue? microliters)
        {
            return microliters.HasValue ? FromMicroliters(microliters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Milliliters.
        /// </summary>
        public static Volume? FromMilliliters(QuantityValue? milliliters)
        {
            return milliliters.HasValue ? FromMilliliters(milliliters.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable OilBarrels.
        /// </summary>
        public static Volume? FromOilBarrels(QuantityValue? oilbarrels)
        {
            return oilbarrels.HasValue ? FromOilBarrels(oilbarrels.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Tablespoons.
        /// </summary>
        public static Volume? FromTablespoons(QuantityValue? tablespoons)
        {
            return tablespoons.HasValue ? FromTablespoons(tablespoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable Teaspoons.
        /// </summary>
        public static Volume? FromTeaspoons(QuantityValue? teaspoons)
        {
            return teaspoons.HasValue ? FromTeaspoons(teaspoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UkTablespoons.
        /// </summary>
        public static Volume? FromUkTablespoons(QuantityValue? uktablespoons)
        {
            return uktablespoons.HasValue ? FromUkTablespoons(uktablespoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsBeerBarrels.
        /// </summary>
        public static Volume? FromUsBeerBarrels(QuantityValue? usbeerbarrels)
        {
            return usbeerbarrels.HasValue ? FromUsBeerBarrels(usbeerbarrels.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsCustomaryCups.
        /// </summary>
        public static Volume? FromUsCustomaryCups(QuantityValue? uscustomarycups)
        {
            return uscustomarycups.HasValue ? FromUsCustomaryCups(uscustomarycups.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsGallons.
        /// </summary>
        public static Volume? FromUsGallons(QuantityValue? usgallons)
        {
            return usgallons.HasValue ? FromUsGallons(usgallons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsLegalCups.
        /// </summary>
        public static Volume? FromUsLegalCups(QuantityValue? uslegalcups)
        {
            return uslegalcups.HasValue ? FromUsLegalCups(uslegalcups.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsOunces.
        /// </summary>
        public static Volume? FromUsOunces(QuantityValue? usounces)
        {
            return usounces.HasValue ? FromUsOunces(usounces.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsPints.
        /// </summary>
        public static Volume? FromUsPints(QuantityValue? uspints)
        {
            return uspints.HasValue ? FromUsPints(uspints.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsQuarts.
        /// </summary>
        public static Volume? FromUsQuarts(QuantityValue? usquarts)
        {
            return usquarts.HasValue ? FromUsQuarts(usquarts.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsTablespoons.
        /// </summary>
        public static Volume? FromUsTablespoons(QuantityValue? ustablespoons)
        {
            return ustablespoons.HasValue ? FromUsTablespoons(ustablespoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Get nullable Volume from nullable UsTeaspoons.
        /// </summary>
        public static Volume? FromUsTeaspoons(QuantityValue? usteaspoons)
        {
            return usteaspoons.HasValue ? FromUsTeaspoons(usteaspoons.Value) : default(Volume?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumeUnit" /> to <see cref="Volume" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Volume unit value.</returns>
        public static Volume? From(QuantityValue? value, VolumeUnit fromUnit)
        {
            return value.HasValue ? new Volume((double)value.Value, fromUnit) : default(Volume?);
        }

        #endregion

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(VolumeUnit unit, [CanBeNull] IFormatProvider provider)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #region Arithmetic Operators

        public static Volume operator -(Volume right)
        {
            return new Volume(-right.Value, right.Unit);
        }

        public static Volume operator +(Volume left, Volume right)
        {
            return new Volume(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Volume operator -(Volume left, Volume right)
        {
            return new Volume(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Volume operator *(double left, Volume right)
        {
            return new Volume(left * right.Value, right.Unit);
        }

        public static Volume operator *(Volume left, double right)
        {
            return new Volume(left.Value * right, left.Unit);
        }

        public static Volume operator /(Volume left, double right)
        {
            return new Volume(left.Value / right, left.Unit);
        }

        public static double operator /(Volume left, Volume right)
        {
            return left.CubicMeters / right.CubicMeters;
        }

        #endregion

        public static bool operator <=(Volume left, Volume right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Volume left, Volume right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Volume left, Volume right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Volume left, Volume right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Volume left, Volume right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Volume left, Volume right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Volume Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<Volume, VolumeUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    VolumeUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromCubicMeters(x.CubicMeters + y.CubicMeters));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Volume result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(Volume);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static VolumeUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<VolumeUnit>(str.Trim());

            if (unit == VolumeUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized VolumeUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(VolumeUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(VolumeUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(VolumeUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}