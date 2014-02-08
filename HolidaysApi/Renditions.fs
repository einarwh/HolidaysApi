﻿namespace Aklefdal.Holidays.HttpApi

open System

[<CLIMutable>]
type EasterDefinition = {
    EasterDay : string }

[<CLIMutable>]
type AtomLinkRendition = {
    Rel : string
    Href : string }

[<CLIMutable>]
type LinkListRendition = {
    Links : AtomLinkRendition array }

[<CLIMutable>]
type HolidayRendition = {
    Date : string
    Name : string
    DateLink : AtomLinkRendition }

[<CLIMutable>]
type HolidaysRendition = {
    Holidays : HolidayRendition array }