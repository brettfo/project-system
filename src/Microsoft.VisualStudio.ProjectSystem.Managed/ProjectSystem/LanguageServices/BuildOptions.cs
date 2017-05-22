﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Microsoft.VisualStudio.ProjectSystem.LanguageServices
{
    internal class BuildOptions
    {
        public BuildOptions(ImmutableArray<CommandLineSourceFile> sourceFiles, ImmutableArray<CommandLineSourceFile> additionalFiles, ImmutableArray<CommandLineReference> metadataReferences, ImmutableArray<CommandLineAnalyzerReference> analyzerReferences)
        {
            SourceFiles = sourceFiles;
            AdditionalFiles = additionalFiles;
            MetadataReferences = metadataReferences;
            AnalyzerReferences = analyzerReferences;
        }

        public ImmutableArray<CommandLineSourceFile> SourceFiles
        {
            get;
        }

        public ImmutableArray<CommandLineSourceFile> AdditionalFiles
        {
            get;
        }

        public ImmutableArray<CommandLineReference> MetadataReferences
        {
            get;
        }

        public ImmutableArray<CommandLineAnalyzerReference> AnalyzerReferences
        {
            get;
        }

        public static BuildOptions FromCommandLineArguments(CommandLineArguments commandLineArguments)
        {
            Requires.NotNull(commandLineArguments, nameof(commandLineArguments));

            return new BuildOptions(
                commandLineArguments.SourceFiles,
                commandLineArguments.AdditionalFiles,
                commandLineArguments.MetadataReferences,
                commandLineArguments.AnalyzerReferences);
        }
    }
}
