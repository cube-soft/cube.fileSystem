﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using System;
using System.IO;

namespace Cube.FileSystem
{
    /* --------------------------------------------------------------------- */
    ///
    /// IInformation
    ///
    /// <summary>
    /// ファイルまたはディレクトリの情報を保持するための
    /// インターフェースです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public interface IInformation
    {
        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Exists
        ///
        /// <summary>
        /// ファイルまたはディレクトリが存在するかどうかを示す値を
        /// 取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        bool Exists { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// IsDirectory
        ///
        /// <summary>
        /// ディレクトリかどうかを示す値を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        bool IsDirectory { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// Name
        ///
        /// <summary>
        /// ファイル名を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        string Name { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// NameWithoutExtension
        ///
        /// <summary>
        /// 拡張子を除いたファイル名を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        string NameWithoutExtension { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// Extension
        ///
        /// <summary>
        /// 拡張子を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        string Extension { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// FullName
        ///
        /// <summary>
        /// 完全なパスを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        string FullName { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// DirectoryName
        ///
        /// <summary>
        /// ファイルまたはディレクトリの親ディレクトリのパスを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        string DirectoryName { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// Length
        ///
        /// <summary>
        /// ファイルサイズを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        long Length { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// Attributes
        ///
        /// <summary>
        /// ファイルまたはディレクトリの属性を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        FileAttributes Attributes { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// CreationTime
        ///
        /// <summary>
        /// ファイルまたはディレクトリの作成日時を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        DateTime CreationTime { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// LastWriteTime
        ///
        /// <summary>
        /// ファイルまたはディレクトリの最終更新日時を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        DateTime LastWriteTime { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// LastAccessTime
        ///
        /// <summary>
        /// ファイルまたはディレクトリの最終アクセス日時を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        DateTime LastAccessTime { get; }

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Refresh
        ///
        /// <summary>
        /// オブジェクトを最新の状態に更新します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        void Refresh();

        #endregion
    }
}
