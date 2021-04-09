using Business.Abstract;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dto;
using DataAccess.Concrete;
using System.Linq;

namespace Business.Concrete
{
    public class QueryService: IQueryService
    {
        public QueryService()
        {
        
        }
        #region TypeOne
        public IDataResult<List<TypeOne_ArticleOne>> TypeOne_ArticleOne()
        { 
            using (Dal dal = new Dal())
            {
                List<TypeOne_ArticleOne> result = new List<TypeOne_ArticleOne>();
                
                var response = (from taxi in dal.taxi_info
                              group taxi by taxi.PUDatetime.Date into g
                              select new
                              {
                                  PUDatetime = g.Key,
                                  passenger_count = g.Sum(p => p.passenger_count),
                              }).OrderByDescending(p => p.passenger_count).Take(5).ToList();

                response.ForEach(p =>
                {
                    result.Add(new TypeOne_ArticleOne { 
                        PUDatetime= p.PUDatetime,
                        passenger_count= p.passenger_count,
                    });
                });

                return new SuccessDataResult<List<TypeOne_ArticleOne>>(data: result);
            }
        }

        public IDataResult<List<TypeOne_ArticleTwo>> TypeOne_ArticleTwo(TypeOne_ArticleTwo_Input input)
        {
            using (Dal dal = new Dal())
            {
                List<TypeOne_ArticleTwo> result = new List<TypeOne_ArticleTwo>();

                var response = (from taxi in dal.taxi_info
                              where taxi.trip_distance < input.distance
                              group taxi by taxi.PUDatetime into g
                              select new
                              {
                                  PUDatetime = g.Key,
                                  trip_distance = g.Sum(p => p.trip_distance),
                              }).OrderByDescending(p => p.trip_distance).Take(5).ToList();

                response.ForEach(p =>
                {
                    result.Add(new TypeOne_ArticleTwo
                    {
                        PUDatetime= p.PUDatetime,
                        trip_distance = p.trip_distance,
                    });
                });

                return new SuccessDataResult<List<TypeOne_ArticleTwo>>(data: result);
            }
        }

        public IDataResult<List<TypeOne_ArticleThree>> TypeOne_ArticleThree()
        {
            using (Dal dal = new Dal())
            {
                List<TypeOne_ArticleThree> result = new List<TypeOne_ArticleThree>();

                var response = (from taxi in dal.taxi_info
                                select new
                                {
                                    PUDatetime = taxi.PUDatetime,
                                    trip_distance = taxi.trip_distance,
                                }).OrderByDescending(p => p.trip_distance).Take(5).ToList();

                response.ForEach(p =>
                {
                    result.Add(new TypeOne_ArticleThree
                    {
                        PUDatetime = p.PUDatetime,
                        trip_distance = p.trip_distance,
                    });
                });

                return new SuccessDataResult<List<TypeOne_ArticleThree>>(data: result);
            }
        }
        #endregion 
        #region TypeTwo
        public IDataResult<List<TypeTwo_ArticleOne>> TypeTwo_ArticleOne(TypeTwo_ArticleOne_Input input)
        {
            using (Dal dal = new Dal())
            {
                List<TypeTwo_ArticleOne> result = new List<TypeTwo_ArticleOne>();

                var response = new {  taxi_count = (from taxi in dal.taxi_info
                                      where taxi.PUDatetime >= input.FirstDate && 
                                            taxi.PUDatetime <= input.SecondDate && 
                                            taxi.PULocationID == input.PULocationID
                                      select new { id = taxi.ID }).Count()
                };
                result.Add(new TypeTwo_ArticleOne
                {
                    taxi_count= response.taxi_count,
                });
              
                return new SuccessDataResult<List<TypeTwo_ArticleOne>>(data: result);
            }
        }

        public IDataResult<List<TypeTwo_ArticleTwo>> TypeTwo_ArticleTwo()
        {
            using (Dal dal = new Dal())
            {
                List<TypeTwo_ArticleTwo> result = new List<TypeTwo_ArticleTwo>();

                var response = (from taxi in dal.taxi_info
                                group taxi by taxi.PUDatetime.Date into g
                                select new
                                {
                                    PUDatetime = g.Key,
                                    total_amount_average = g.Sum(p => p.total_amount) / g.Select(p => p.ID).Count(),
                                }
                                ).OrderBy(p => p.total_amount_average).ToList();

                var response2 = response.OrderBy(p => p.PUDatetime.Date).Take(2).ToList();

                var response3 = (from a in response
                                where a.PUDatetime.Date >= response2[0].PUDatetime.Date && 
                                      a.PUDatetime.Date <= response2[1].PUDatetime.Date
                               select new
                               {
                                   PUDatetime = a.PUDatetime,
                                   total_amount_average = a.total_amount_average,
                               }).ToList();

                response3.ForEach(p =>
                {
                    result.Add(new TypeTwo_ArticleTwo
                    {
                        PUDatetime = p.PUDatetime,
                        total_amount_average = p.total_amount_average,
                    });
                });

                return new SuccessDataResult<List<TypeTwo_ArticleTwo>>(data: result);
            }
        }

        public IDataResult<List<TypeTwo_ArticleThree>> TypeTwo_ArticleThree(TypeTwo_ArticleThree_Input input)
        {
            using (Dal dal = new Dal())
            {
                List<TypeTwo_ArticleThree> result = new List<TypeTwo_ArticleThree>();

                var response = (from taxi in dal.taxi_info
                                where taxi.PUDatetime.Date >= input.FirstDate.Date && taxi.PUDatetime.Date <= input.SecondDate.Date
                                select new
                                {
                                    PUDatetime = taxi.PUDatetime,
                                    DODatetime = taxi.DODatetime,
                                    trip_distance = taxi.trip_distance,
                                }).OrderBy(p => p.trip_distance).Take(5).ToList();

                response.ForEach(p =>
                {
                    result.Add(new TypeTwo_ArticleThree
                    {
                        PUDatetime = p.PUDatetime,
                        DODatetime = p.DODatetime,
                        trip_distance = p.trip_distance,
                    });
                });

                return new SuccessDataResult<List<TypeTwo_ArticleThree>>(data: result);
            }
        }
        #endregion 
        #region TypeThree
        public IDataResult<List<TypeThree_ArticleOne>> TypeThree_ArticleOne(TypeThree_ArticleOne_Input input)
        {
            using (Dal dal = new Dal())
            {
                List<TypeThree_ArticleOne> result = new List<TypeThree_ArticleOne>();

                var response = (from taxi in dal.taxi_info
                                where taxi.PUDatetime.Date == input.FirstDate.Date
                                select new
                                {
                                    PUDatetime = taxi.PUDatetime,
                                    DODatetime = taxi.DODatetime,
                                    PULocationID = taxi.PULocationID,
                                    DOLocationID = taxi.DOLocationID,
                                    trip_distance = taxi.trip_distance,
                                }).OrderByDescending(p => p.trip_distance).Take(1).ToList();

                response.ForEach(p =>
                {
                    result.Add(new TypeThree_ArticleOne
                    {
                        PUDatetime = p.PUDatetime,
                        DODatetime = p.DODatetime,
                        PULocationID = p.PULocationID,
                        DOLocationID = p.DOLocationID,
                        trip_distance = p.trip_distance,
                    });
                });

                return new SuccessDataResult<List<TypeThree_ArticleOne>>(data: result);
            }
        }

        public IDataResult<List<TypeThree_ArticleTwo>> TypeThree_ArticleTwo(TypeThree_ArticleTwo_Input input)
        {
            using (Dal dal = new Dal())
            {
                List<TypeThree_ArticleTwo> result = new List<TypeThree_ArticleTwo>();

                var response = (from taxi in dal.taxi_info
                                where taxi.PUDatetime.Date == input.FirstDate.Date && 
                                taxi.PULocationID == input.PULocationID
                                select new
                                {
                                    PULocationID = taxi.PULocationID,
                                    DOLocationID = taxi.DOLocationID,
                                }).Take(5).ToList();

                response.ForEach(p =>
                {
                    result.Add(new TypeThree_ArticleTwo
                    {
                        PULocationID = p.PULocationID,
                        DOLocationID = p.DOLocationID,
                    });
                });

                return new SuccessDataResult<List<TypeThree_ArticleTwo>>(data: result);
            }
        }

        public IDataResult<List<TypeThree_ArticleThree>> TypeThree_ArticleThree()
        {
            using (Dal dal = new Dal())
            {
                List<TypeThree_ArticleThree> result = new List<TypeThree_ArticleThree>();

                var response = (from taxi in dal.taxi_info
                               where taxi.passenger_count >= 3                              select new
                              {
                                  PULocationID = taxi.PULocationID,
                                  DOLocationID = taxi.DOLocationID,
                                  trip_distance = taxi.trip_distance,
                              }).OrderByDescending(p=>p.trip_distance).ToList();
                
                result.Add(new TypeThree_ArticleThree
                    {
                        longest_trip = new row { 
                            PULocationID = response.First().PULocationID,
                            DOLocationID = response.First().DOLocationID,
                            trip_distance = response.First().trip_distance,
                        },
                        shortest_trip = new row
                        {
                            PULocationID = response.Last().PULocationID,
                            DOLocationID = response.Last().DOLocationID,
                            trip_distance = response.Last().trip_distance,
                        },
                });

                return new SuccessDataResult<List<TypeThree_ArticleThree>>(data: result);
            }
        }
        #endregion 
    }
}
