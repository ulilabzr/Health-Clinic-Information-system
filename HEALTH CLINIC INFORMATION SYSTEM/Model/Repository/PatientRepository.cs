using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Context;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository
{
    public class PatientRepository
    {
        private MySqlConnection _conn;

        public PatientRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Patient _pasien)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"INSERT INTO patient(patient_id, name, date_of_birth, gender, address, phone_number, email) VALUES (@patient_id, @name, @date_of_birth, @gender, @address, @phone_number, @email)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@patient_id", _pasien.PatientId);
                cmd.Parameters.AddWithValue("@name", _pasien.Name);
                cmd.Parameters.AddWithValue("@date_of_birth", _pasien.Date_of_birth);
                cmd.Parameters.AddWithValue("@gender", _pasien.Gender);
                cmd.Parameters.AddWithValue("@address", _pasien.Address);
                cmd.Parameters.AddWithValue("@phone_number", _pasien.Phone);
                cmd.Parameters.AddWithValue("@email", _pasien.Email);
                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Patient berhasil disimpan ke db!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Data Patient gagal disimpan ke db!!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Patient _pasien)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"UPDATE patient SET name=@name, date_of_birth=@date_of_birth, gender=@gender, address=@address, phone_number=@phone_number, email=@email WHERE patient_id=@patient_id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@patient_id", _pasien.PatientId);
                cmd.Parameters.AddWithValue("@name", _pasien.Name);
                cmd.Parameters.AddWithValue("@date_of_birth", _pasien.Date_of_birth);
                cmd.Parameters.AddWithValue("@gender", _pasien.Gender);
                cmd.Parameters.AddWithValue("@address", _pasien.Address);
                cmd.Parameters.AddWithValue("@phone_number", _pasien.Phone);
                cmd.Parameters.AddWithValue("@email", _pasien.Email);
                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Patient berhasil diubah ke db!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Data Patient gagal diubah ke db!!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Patient _pasien)
        {
            int result = 0;
            // deklarasi perintah SQL
            string sql = @"DELETE FROM patient WHERE patient_id=@patient_id";
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@patient_id", _pasien.PatientId);
                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Patient> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Patient> list = new List<Patient>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT * FROM patient ORDER BY patient_id";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Patient _pasien = new Patient
                            {
                                PatientId = dtr["patient_id"].ToString(),
                                Name = dtr["name"].ToString(),
                                Date_of_birth = dtr["date_of_birth"].ToString(),
                                Gender = dtr["gender"].ToString(),
                                Address = dtr["address"].ToString(),
                                Phone = dtr["phone"].ToString(),
                                Email = dtr["email"].ToString()
                            };

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_pasien);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<Patient> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Patient> list = new List<Patient>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT * FROM patient WHERE name LIKE @name ORDER BY id";
                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@name", string.Format("%{0}%", nama));
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Patient _pasien = new Patient
                            {
                                PatientId = dtr["patient_id"].ToString(),
                                Name = dtr["name"].ToString(),
                                Date_of_birth = dtr["date_of_birth"].ToString(),
                                Gender = dtr["gender"].ToString(),
                                Address = dtr["address"].ToString(),
                                Phone = dtr["phone"].ToString(),
                                Email = dtr["email"].ToString()
                            };
                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(_pasien);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return list;
        }
    }
}
